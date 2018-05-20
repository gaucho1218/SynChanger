//
//  ViewController.swift
//  SynChanger
//
//  Created by Hansuck Shim on 2018. 5. 3..
//  Copyright © 2018년 gaucho1218. All rights reserved.
//

import Cocoa

class ViewController: NSViewController, NSWindowDelegate, NSTextViewDelegate {
    
    @IBOutlet weak var progressIndicator: NSProgressIndicator!
    @IBOutlet weak var beforeView: NSScrollView!
    @IBOutlet weak var afterView: NSScrollView!
    @IBOutlet weak var ResultLabel: NSTextField!
    @IBOutlet var beforeText: NSTextView!
    @IBOutlet var afterText: NSTextView!
    
    override func viewDidAppear() {
        view.window?.delegate = self
    }
    
    override func viewDidLoad() {
        super.viewDidLoad()

        // Do any additional setup after loading the view.
        beforeText.delegate = self
    }

    override var representedObject: Any? {
        didSet {
        // Update the view, if already loaded.
        }
    }
    
    func textDidChange(_ notification: Notification) {
        DispatchQueue.main.async()
        {
            self.afterText.string = ""
            self.progressIndicator.minValue = 0
            self.progressIndicator.maxValue = Double(self.beforeText.string.count)
            
            for c in self.beforeText.string
            {
                switch c
                {
                case "<":
                    self.afterText.string += "&lt;"
                    break
                case ">":
                    self.afterText.string += "&gt;"
                    break
                case "&":
                    self.afterText.string += "&amp;"
                    break
                case "\"":
                    self.afterText.string += "&quot;"
                    break
                default:
                    self.afterText.string += String(c)
                    break
                }
                
                self.progressIndicator.increment(by: 1)
            }
        }
    }
    
    func windowDidResize(_ notification: Notification) {
        let width = (view.window?.frame.size.width)!
        let height = (view.window?.frame.size.height)!
   
        progressIndicator.frame = NSMakeRect(20, height - 53, width - 40, 20)
        ResultLabel.frame = NSMakeRect(width/2 + 8, height - 77 , 42, 17)
        
        beforeView.frame = NSMakeRect(20, 20, width/2 - 30, height - 113)
        afterView.frame = NSMakeRect(width/2 + 10, 20, width/2 - 30, height - 113)
    }
}

//
//  ViewController.swift
//  SynChanger
//
//  Created by Hansuck Shim on 2018. 5. 3..
//  Copyright © 2018년 gaucho1218. All rights reserved.
//

import Cocoa

class ViewController: NSViewController, NSWindowDelegate {

    @IBOutlet weak var afterField: NSTextField!
    @IBOutlet weak var beforeField: NSTextField!
    
    @IBOutlet weak var progressIndicator: NSProgressIndicator!
    @IBOutlet weak var beforeView: NSScrollView!
    @IBOutlet weak var afterView: NSScrollView!
    
    override func viewDidAppear() {
        view.window?.delegate = self
    }
    
    override func viewDidLoad() {
        super.viewDidLoad()

        // Do any additional setup after loading the view.
    }

    override var representedObject: Any? {
        didSet {
        // Update the view, if already loaded.
        }
    }
    
    @IBAction func beforeFiledChanged(_ sender: NSTextField) {
        /*
        afterView.stringValue = ""
        
        for c in sender.stringValue
        {
            switch c
            {
            case "<":
                afterView.stringValue += "&lt;"
                break
            case ">":
                afterView.stringValue += "&gt;"
                break
            case "&":
                afterView.stringValue += "&amp;"
                break
            case "\"":
                afterView.stringValue += "&quot;"
                break
            default:
                afterView.stringValue += String(c)
                break
            }
        }
 */
    }
    
    func windowDidResize(_ notification: Notification) {
        let width = (((view.window?.frame.size.width)! - 50) / 2)
        let height = (((view.window?.frame.size.height)! - 50))
        
        beforeView.frame = NSMakeRect(15, 15, width, height)
        afterView.frame = NSMakeRect(width + 35, 15, width, height)
    }
}

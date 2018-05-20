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
        afterField.stringValue = ""
        
        for c in sender.stringValue
        {
            switch c
            {
            case "<":
                afterField.stringValue += "&lt;"
                break
            case ">":
                afterField.stringValue += "&gt;"
                break
            case "&":
                afterField.stringValue += "&amp;"
                break
            case "\"":
                afterField.stringValue += "&quot;"
                break
            default:
                afterField.stringValue += String(c)
                break
            }
        }
    }
    
    func windowDidResize(_ notification: Notification) {
        let width = (((view.window?.frame.size.width)! - 50) / 2)
        let height = (((view.window?.frame.size.height)! - 50))
        
        beforeField.frame = NSMakeRect(15, 15, width, height)
        afterField.frame = NSMakeRect(width + 35, 15, width, height)
    }
}

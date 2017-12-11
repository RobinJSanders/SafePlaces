<!-- Text input-->
        <div class="form-group">
            <label class="col-md-4 control-label" for="Date_Recorded">Date</label>
            <div class="col-md-4">
                <input id="Date" name="Date_Recorded" type="text" placeholder="" class="form-control input-md">

            </div>
        </div>
        <!-- Text input-->
        <div class="form-group">
            <label class="col-md-4 control-label" for="Employee_Name">Employee Name</label>
            <div class="col-md-4">
                <input id="Employee_Name" name="Employee_Name" type="text" placeholder="" class="form-control input-md">

            </div>
        </div>
        <!-- Text input-->
        <div class="form-group">
            <label class="col-md-4 control-label" for="Busness_Name">Busness Name</label>
            <div class="col-md-4">
                <input id="Busness_Name" name="Busness_Name" type="text" placeholder="" class="form-control input-md">

            </div>
        </div>
        <!-- Select Basic -->
        <div class="form-group">
            <label class="col-md-4 control-label" for="selectbasic">What was the situation?</label>
            <div class="col-md-4">
                <select id="selectbasic" name="selectbasic" class="form-control">
                    <option value="Lost">Lost</option>
                    <option value="In Pain">In Pain</option>
                    <option value="Distressed">Distressed</option>
                    <option value="Chat">Chat</option>
                    <option value="Missed Transport">Missed Transport</option>
                    <option value="Other">Other</option>
                </select>
            </div>
        </div>

        <!-- Text input-->
        <div class="form-group">
            <label class="col-md-4 control-label" for="If_Other">If Other, please state</label>
            <div class="col-md-4">
                <input id="If_Other" name="If_Other" type="text" placeholder="" class="form-control input-md">

            </div>
        </div>
        <!-- Text input-->
        <div class="form-group">
            <label class="col-md-4 control-label" for="How_Resolved">How Was it resolved?</label>
            <div class="col-md-4">
                <input id="How_Resolved" name="How_Resolved" type="text" placeholder="" class="form-control input-md">
            </div>
        </div>
        <!-- Multiple Radios -->
        <div class="form-group">
            <label class="col-md-4 control-label" for="Critical">Choose the correct one</label>
            <div class="col-md-4">
                <div class="radio">
                    <label for="Critical-0">
                        <input type="radio" name="Critical" id="Critical-0" value="1" checked="checked">
                        Critical
                    </label>
                </div>
                <div class="radio">
                    <label for="Critical-1">
                        <input type="radio" name="Critical" id="Critical-1" value="2">
                        Non-Critical
                    </label>
                </div>
            </div>
        </div>
        <!-- Textarea -->
        <div class="form-group">
            <label class="col-md-4 control-label" for="Details">Any More Details</label>
            <div class="col-md-4">
                <textarea class="form-control" id="Details" name="Details"></textarea>
            </div>
        </div>
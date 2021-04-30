import React from 'react';
import TweetCard from './TweetCard';
import { ReactComponent as CloseButton } from '../images/Close.svg';


function TweetModal({ twitterData }) {

    return (
        <div className="modal-dialog">
            <div className="modal-content">
                <div className="modal-header">
                    <h3 className="modal-title">It's a random Tweet</h3>
                    <button
                        type="button"
                        className="close"
                        data-dismiss="modal"
                        aria-label="Close">
                        <CloseButton />
                    </button>
                </div>
                <div className="modal-body">
                    <TweetCard
                        twitterData={twitterData}
                    />
                </div>
            </div>
        </div>
    )
}

export default TweetModal
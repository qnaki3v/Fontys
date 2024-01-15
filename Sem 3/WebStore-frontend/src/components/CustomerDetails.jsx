const CustomerDetails = ({ customerDetails }) => {
    return (
        <div>
            <p>Customer Details:</p>
            <ul>
                <li>ID: {customerDetails.id}</li>
                <li>PCN: {customerDetails.username}</li>
            </ul>
        </div>
    );
};

export default CustomerDetails;
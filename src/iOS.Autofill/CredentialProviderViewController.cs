using AuthenticationServices;
using Foundation;
using System;
using UIKit;

namespace Bit.iOS.Autofill
{
    public partial class CredentialProviderViewController : ASCredentialProviderViewController
    {
        public CredentialProviderViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void PrepareCredentialList(ASCredentialServiceIdentifier[] serviceIdentifiers)
        {
            base.PrepareCredentialList(serviceIdentifiers);
        }

        public override void ProvideCredentialWithoutUserInteraction(ASPasswordCredentialIdentity credentialIdentity)
        {
            base.ProvideCredentialWithoutUserInteraction(credentialIdentity);
        }

        public override void PrepareInterfaceToProvideCredential(ASPasswordCredentialIdentity credentialIdentity)
        {
            base.PrepareInterfaceToProvideCredential(credentialIdentity);
        }

        public override void PrepareInterfaceForExtensionConfiguration()
        {
            base.PrepareInterfaceForExtensionConfiguration();
        }
    }
}
import { CometSocialTemplatePage } from './app.po';

describe('CometSocial App', function() {
  let page: CometSocialTemplatePage;

  beforeEach(() => {
    page = new CometSocialTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

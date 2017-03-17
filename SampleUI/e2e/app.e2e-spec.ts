import { SampleUIPage } from './app.po';

describe('sample-ui App', () => {
  let page: SampleUIPage;

  beforeEach(() => {
    page = new SampleUIPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

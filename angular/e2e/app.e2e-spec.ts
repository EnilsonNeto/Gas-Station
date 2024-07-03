import { Gas_stationTemplatePage } from './app.po';

describe('Gas_station App', function() {
  let page: Gas_stationTemplatePage;

  beforeEach(() => {
    page = new Gas_stationTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

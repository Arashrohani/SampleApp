import { NgModule }     from '@angular/core';
import { RouterModule } from '@angular/router';

import { ExtensionsComponent } from './extension/extension.component';
import { IdentityComponent } from './identity/identity.component';
import {HomeComponent} from './home/home.component';

@NgModule({
  imports: [
    RouterModule.forRoot([
      { 
          path: 'extensions', 
          component: ExtensionsComponent
        },
      { 
          path: 'login', 
          component: IdentityComponent 
        },
        {
            path: '',
            component: HomeComponent
        },
        {
            path: '**',
            component: HomeComponent
        }

    //   {
    //     path: 'admin',
    //     loadChildren: 'app/admin/admin.module#AdminModule',
    //     canLoad: [AuthGuard]
    //   },
    //   {
    //     path: '',
    //     redirectTo: '/heroes',
    //     pathMatch: 'full'
    //   },
    //   {
    //     path: 'crisis-center',
    //     loadChildren: 'app/crisis-center/crisis-center.module#CrisisCenterModule',
    //     data: {
    //       preload: true
    //     }
    //   }
    ]
    //,{ preloadingStrategy: PreloadSelectedModules }
    )
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule {}
using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_cbf1-11183d41")]
        public void Method_1008_cbf1()
        {
            ii(0x1008_cbf1, 5); push(0x40);                             /* push 0x40 */
            ii(0x1008_cbf6, 5); call(Definitions.sys_check_available_stack_size, 0xd_9157); /* call 0x10165d52 */
            ii(0x1008_cbfb, 1); push(ebx);                              /* push ebx */
            ii(0x1008_cbfc, 1); push(ecx);                              /* push ecx */
            ii(0x1008_cbfd, 1); push(esi);                              /* push esi */
            ii(0x1008_cbfe, 1); push(edi);                              /* push edi */
            ii(0x1008_cbff, 1); push(ebp);                              /* push ebp */
            ii(0x1008_cc00, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_cc02, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1008_cc08, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_cc0b, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_cc0e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_cc11, 3); mov(eax, memd[ds, eax + 0x21]);         /* mov eax, [eax+0x21] */
            ii(0x1008_cc14, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_cc17, 1); inc(eax);                               /* inc eax */
            ii(0x1008_cc18, 1); push(eax);                              /* push eax */
            ii(0x1008_cc19, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_cc1c, 3); mov(eax, memd[ds, eax + 0x1f]);         /* mov eax, [eax+0x1f] */
            ii(0x1008_cc1f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_cc22, 1); inc(eax);                               /* inc eax */
            ii(0x1008_cc23, 1); push(eax);                              /* push eax */
            ii(0x1008_cc24, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_cc27, 3); mov(eax, memd[ds, eax + 0x11]);         /* mov eax, [eax+0x11] */
            ii(0x1008_cc2a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_cc2d, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1008_cc30, 6); push(memd[ds, eax + 0x101c_81d7]);      /* push dword [eax+0x101c81d7] */
            ii(0x1008_cc36, 5); mov(eax, StringDefinitions.CreateASAtII); /* mov eax, 0x101a0476 */
            ii(0x1008_cc3b, 1); push(eax);                              /* push eax */
            ii(0x1008_cc3c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_cc3f, 1); push(eax);                              /* push eax */
            ii(0x1008_cc40, 5); call(Definitions.sys_sprintf, 0xd_92bc); /* call 0x10165f01 */
            ii(0x1008_cc45, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x1008_cc48, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_cc4b, 3); mov(al, memb[ds, eax + 0x25]);          /* mov al, [eax+0x25] */
            ii(0x1008_cc4e, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x1008_cc51, 5); jmp(0x1008_cd68, 0x112); goto l_0x1008_cd68; /* jmp 0x1008cd68 */
        l_0x1008_cc56:
            ii(0x1008_cc56, 5); mov(edx, StringDefinitions.Initializing); /* mov edx, 0x101a048d */
            ii(0x1008_cc5b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_cc5e, 5); call(Definitions.sys_strcat, 0xd_92ce); /* call 0x10165f31 */
            ii(0x1008_cc63, 5); jmp(0x1008_cd83, 0x11b); goto l_0x1008_cd83; /* jmp 0x1008cd83 */
        l_0x1008_cc68:
            ii(0x1008_cc68, 5); mov(edx, StringDefinitions.RemovingMines2); /* mov edx, 0x101a049c */
            ii(0x1008_cc6d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_cc70, 5); call(Definitions.sys_strcat, 0xd_92bc); /* call 0x10165f31 */
            ii(0x1008_cc75, 5); jmp(0x1008_cd83, 0x109); goto l_0x1008_cd83; /* jmp 0x1008cd83 */
        l_0x1008_cc7a:
            ii(0x1008_cc7a, 5); mov(edx, StringDefinitions.WaitingForPlatform); /* mov edx, 0x101a04ad */
            ii(0x1008_cc7f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_cc82, 5); call(Definitions.sys_strcat, 0xd_92aa); /* call 0x10165f31 */
            ii(0x1008_cc87, 5); jmp(0x1008_cd83, 0xf7); goto l_0x1008_cd83; /* jmp 0x1008cd83 */
        l_0x1008_cc8c:
            ii(0x1008_cc8c, 5); mov(edx, StringDefinitions.GetBuilder); /* mov edx, 0x101a04c4 */
            ii(0x1008_cc91, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_cc94, 5); call(Definitions.sys_strcat, 0xd_9298); /* call 0x10165f31 */
            ii(0x1008_cc99, 5); jmp(0x1008_cd83, 0xe5); goto l_0x1008_cd83; /* jmp 0x1008cd83 */
        l_0x1008_cc9e:
            ii(0x1008_cc9e, 5); mov(edx, StringDefinitions.GetMaterials); /* mov edx, 0x101a04d2 */
            ii(0x1008_cca3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_cca6, 5); call(Definitions.sys_strcat, 0xd_9286); /* call 0x10165f31 */
            ii(0x1008_ccab, 5); jmp(0x1008_cd83, 0xd3); goto l_0x1008_cd83; /* jmp 0x1008cd83 */
        l_0x1008_ccb0:
            ii(0x1008_ccb0, 5); mov(edx, StringDefinitions.MoveToSite); /* mov edx, 0x101a04e2 */
            ii(0x1008_ccb5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_ccb8, 5); call(Definitions.sys_strcat, 0xd_9274); /* call 0x10165f31 */
            ii(0x1008_ccbd, 5); jmp(0x1008_cd83, 0xc1); goto l_0x1008_cd83; /* jmp 0x1008cd83 */
        l_0x1008_ccc2:
            ii(0x1008_ccc2, 5); mov(edx, StringDefinitions.EvaluatingSite); /* mov edx, 0x101a04f1 */
            ii(0x1008_ccc7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_ccca, 5); call(Definitions.sys_strcat, 0xd_9262); /* call 0x10165f31 */
            ii(0x1008_cccf, 5); jmp(0x1008_cd83, 0xaf); goto l_0x1008_cd83; /* jmp 0x1008cd83 */
        l_0x1008_ccd4:
            ii(0x1008_ccd4, 5); mov(edx, StringDefinitions.SiteBlocked); /* mov edx, 0x101a0503 */
            ii(0x1008_ccd9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_ccdc, 5); call(Definitions.sys_strcat, 0xd_9250); /* call 0x10165f31 */
            ii(0x1008_cce1, 5); jmp(0x1008_cd83, 0x9d); goto l_0x1008_cd83; /* jmp 0x1008cd83 */
        l_0x1008_cce6:
            ii(0x1008_cce6, 5); mov(edx, StringDefinitions.ClearSite);  /* mov edx, 0x101a0512 */
            ii(0x1008_cceb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_ccee, 5); call(Definitions.sys_strcat, 0xd_923e); /* call 0x10165f31 */
            ii(0x1008_ccf3, 5); jmp(0x1008_cd83, 0x8b); goto l_0x1008_cd83; /* jmp 0x1008cd83 */
        l_0x1008_ccf8:
            ii(0x1008_ccf8, 5); mov(edx, StringDefinitions.Building3);  /* mov edx, 0x101a051f */
            ii(0x1008_ccfd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_cd00, 5); call(Definitions.sys_strcat, 0xd_922c); /* call 0x10165f31 */
            ii(0x1008_cd05, 5); jmp(0x1008_cd83, 0x79); goto l_0x1008_cd83; /* jmp 0x1008cd83 */
        l_0x1008_cd0a:
            ii(0x1008_cd0a, 5); mov(edx, StringDefinitions.MoveOffSite); /* mov edx, 0x101a052a */
            ii(0x1008_cd0f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_cd12, 5); call(Definitions.sys_strcat, 0xd_921a); /* call 0x10165f31 */
            ii(0x1008_cd17, 2); jmp(0x1008_cd83, 0x6a); goto l_0x1008_cd83; /* jmp 0x1008cd83 */
        l_0x1008_cd19:
            ii(0x1008_cd19, 5); mov(edx, StringDefinitions.Finished3);  /* mov edx, 0x101a053a */
            ii(0x1008_cd1e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_cd21, 5); call(Definitions.sys_strcat, 0xd_920b); /* call 0x10165f31 */
            ii(0x1008_cd26, 2); jmp(0x1008_cd83, 0x5b); goto l_0x1008_cd83; /* jmp 0x1008cd83 */
        l_0x1008_cd28:
            ii(0x1008_cd28, 5); mov(edx, StringDefinitions.UnknownState); /* mov edx, 0x101a0546 */
            ii(0x1008_cd2d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_cd30, 5); call(Definitions.sys_strcat, 0xd_91fc); /* call 0x10165f31 */
            ii(0x1008_cd35, 2); jmp(0x1008_cd83, 0x4c); goto l_0x1008_cd83; /* jmp 0x1008cd83 */
        //  ii(0x1008_cd37, 1); nop();                                  /* nop */
        //  ii(0x1008_cd38, 48); /* Служебная область с абсолютными адресами переходов. (0x1008_cc56, 0x1008_cc7a, 0x1008_cc68, 0x1008_cc8c, 0x1008_cc9e, 0x1008_ccc2, 0x1008_ccd4, 0x1008_ccb0, 0x1008_cce6, 0x1008_ccf8, 0x1008_cd0a, 0x1008_cd19). */
        l_0x1008_cd68:
            ii(0x1008_cd68, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1008_cd6b, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
            ii(0x1008_cd6e, 4); cmp(memb[ss, ebp - 0x14], 0xb);         /* cmp byte [ebp-0x14], 0xb */
            ii(0x1008_cd72, 2); if(ja(0x1008_cd28, -0x4c)) goto l_0x1008_cd28; /* ja 0x1008cd28 */
            ii(0x1008_cd74, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_cd76, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x1008_cd79, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1008_cd7c, 7); 
            switch (jmp_abs_switch(memd[cs, eax + 0x1008_cd38]))
            {
                case 0x1008_cc56:
                    goto l_0x1008_cc56;
                case 0x1008_cc68:
                    goto l_0x1008_cc68;
                case 0x1008_cc7a:
                    goto l_0x1008_cc7a;
                case 0x1008_cc8c:
                    goto l_0x1008_cc8c;
                case 0x1008_cc9e:
                    goto l_0x1008_cc9e;
                case 0x1008_ccb0:
                    goto l_0x1008_ccb0;
                case 0x1008_ccc2:
                    goto l_0x1008_ccc2;
                case 0x1008_ccd4:
                    goto l_0x1008_ccd4;
                case 0x1008_cce6:
                    goto l_0x1008_cce6;
                case 0x1008_ccf8:
                    goto l_0x1008_ccf8;
                case 0x1008_cd0a:
                    goto l_0x1008_cd0a;
                case 0x1008_cd19:
                    goto l_0x1008_cd19;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax+0x1008cd38] */
        l_0x1008_cd83:
            ii(0x1008_cd83, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_cd85, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_cd88, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_cd8b, 5); call(0x1013_ad71, 0xa_dfe1);            /* call 0x1013ad71 */
            ii(0x1008_cd90, 2); test(al, al);                           /* test al, al */
            ii(0x1008_cd92, 2); if(jz(0x1008_cdaa, 0x16)) goto l_0x1008_cdaa; /* jz 0x1008cdaa */
            ii(0x1008_cd94, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_cd97, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_cd9a, 5); call(0x1007_6574, -0x1_682b);           /* call 0x10076574 */
            ii(0x1008_cd9f, 5); call(0x1009_c9a0, 0xfbfc);              /* call 0x1009c9a0 */
            ii(0x1008_cda4, 1); cwde();                                 /* cwde */
            ii(0x1008_cda5, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1008_cda8, 2); if(jg(0x1008_cdac, 2)) goto l_0x1008_cdac; /* jg 0x1008cdac */
        l_0x1008_cdaa:
            ii(0x1008_cdaa, 2); jmp(0x1008_cdb9, 0xd); goto l_0x1008_cdb9; /* jmp 0x1008cdb9 */
        l_0x1008_cdac:
            ii(0x1008_cdac, 5); mov(edx, StringDefinitions.AtX2Rate);   /* mov edx, 0x101a0557 */
            ii(0x1008_cdb1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_cdb4, 5); call(Definitions.sys_strcat, 0xd_9178); /* call 0x10165f31 */
        l_0x1008_cdb9:
            ii(0x1008_cdb9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_cdbc, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_cdbf, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_cdc2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_cdc4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_cdc5, 1); pop(edi);                               /* pop edi */
            ii(0x1008_cdc6, 1); pop(esi);                               /* pop esi */
            ii(0x1008_cdc7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_cdc8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_cdc9, 1); ret();                                  /* ret */
        }
    }
}

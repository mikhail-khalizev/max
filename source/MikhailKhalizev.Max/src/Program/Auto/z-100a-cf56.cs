using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_cf56-dbc8301e")]
        public void Method_100a_cf56()
        {
            ii(0x100a_cf56, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_cf5b, 5); call(Definitions.sys_check_available_stack_size, 0xb_8df2); /* call 0x10165d52 */
            ii(0x100a_cf60, 1); push(ebx);                              /* push ebx */
            ii(0x100a_cf61, 1); push(ecx);                              /* push ecx */
            ii(0x100a_cf62, 1); push(edx);                              /* push edx */
            ii(0x100a_cf63, 1); push(esi);                              /* push esi */
            ii(0x100a_cf64, 1); push(edi);                              /* push edi */
            ii(0x100a_cf65, 1); push(ebp);                              /* push ebp */
            ii(0x100a_cf66, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_cf68, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100a_cf6e, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_cf71, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_cf73, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_cf76, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_cf79, 5); call(0x1013_ad71, 0x8_ddf3);            /* call 0x1013ad71 */
            ii(0x100a_cf7e, 2); test(al, al);                           /* test al, al */
            ii(0x100a_cf80, 6); if(jz(0x100a_d024, 0x9e)) goto l_0x100a_d024; /* jz 0x100ad024 */
            ii(0x100a_cf86, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_cf89, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_cf8c, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_cf8f, 5); call(0x1007_6574, -0x3_6a20);           /* call 0x10076574 */
            ii(0x100a_cf94, 5); call(0x1015_2a52, 0xa_5ab9);            /* call 0x10152a52 */
            ii(0x100a_cf99, 2); test(al, al);                           /* test al, al */
            ii(0x100a_cf9b, 6); if(jz(0x100a_d024, 0x83)) goto l_0x100a_d024; /* jz 0x100ad024 */
            ii(0x100a_cfa1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_cfa4, 4); cmp(memb[ds, eax + 68], 0);             /* cmp byte [eax+0x44], 0x0 */
            ii(0x100a_cfa8, 2); if(jz(0x100a_cfc1, 0x17)) goto l_0x100a_cfc1; /* jz 0x100acfc1 */
            ii(0x100a_cfaa, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_cfad, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_cfb0, 5); call(0x1007_6574, -0x3_6a41);           /* call 0x10076574 */
            ii(0x100a_cfb5, 3); mov(al, memb[ds, eax + 78]);            /* mov al, [eax+0x4e] */
            ii(0x100a_cfb8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_cfbd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_cfbf, 2); if(jz(0x100a_cfc3, 2)) goto l_0x100a_cfc3; /* jz 0x100acfc3 */
        l_0x100a_cfc1:
            ii(0x100a_cfc1, 2); jmp(0x100a_cfcd, 0xa); goto l_0x100a_cfcd; /* jmp 0x100acfcd */
        l_0x100a_cfc3:
            ii(0x100a_cfc3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_cfc6, 5); cmp(memw[ds, eax + 38], -1 /* 0xff */); /* cmp word [eax+0x26], 0xffff */
            ii(0x100a_cfcb, 2); if(jz(0x100a_cfcf, 2)) goto l_0x100a_cfcf; /* jz 0x100acfcf */
        l_0x100a_cfcd:
            ii(0x100a_cfcd, 2); jmp(0x100a_cfdb, 0xc); goto l_0x100a_cfdb; /* jmp 0x100acfdb */
        l_0x100a_cfcf:
            ii(0x100a_cfcf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_cfd1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_cfd4, 5); call(0x100a_d02d, 0x54);                /* call 0x100ad02d */
            ii(0x100a_cfd9, 2); jmp(0x100a_d024, 0x49); goto l_0x100a_d024; /* jmp 0x100ad024 */
        l_0x100a_cfdb:
            ii(0x100a_cfdb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_cfde, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_cfe1, 5); call(0x1007_6574, -0x3_6a72);           /* call 0x10076574 */
            ii(0x100a_cfe6, 3); mov(al, memb[ds, eax + 78]);            /* mov al, [eax+0x4e] */
            ii(0x100a_cfe9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_cfee, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_cff0, 2); if(jz(0x100a_d003, 0x11)) goto l_0x100a_d003; /* jz 0x100ad003 */
            ii(0x100a_cff2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_cff4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_cff7, 3); add(eax, 0x3c);                         /* add eax, 0x3c */
            ii(0x100a_cffa, 5); call(0x1013_ad11, 0x8_dd12);            /* call 0x1013ad11 */
            ii(0x100a_cfff, 2); test(al, al);                           /* test al, al */
            ii(0x100a_d001, 2); if(jnz(0x100a_d005, 2)) goto l_0x100a_d005; /* jnz 0x100ad005 */
        l_0x100a_d003:
            ii(0x100a_d003, 2); jmp(0x100a_d024, 0x1f); goto l_0x100a_d024; /* jmp 0x100ad024 */
        l_0x100a_d005:
            ii(0x100a_d005, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_d008, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_d00b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_d00e, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x100a_d011, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_d014, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_d017, 5); call(0x1007_65d0, -0x3_6a4c);           /* call 0x100765d0 */
            ii(0x100a_d01c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_d01e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_d021, 3); call_abs(memd[ds, ebx + 68]);           /* call dword [ebx+0x44] */
        l_0x100a_d024:
            ii(0x100a_d024, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_d026, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_d027, 1); pop(edi);                               /* pop edi */
            ii(0x100a_d028, 1); pop(esi);                               /* pop esi */
            ii(0x100a_d029, 1); pop(edx);                               /* pop edx */
            ii(0x100a_d02a, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_d02b, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_d02c, 1); ret();                                  /* ret */
        }
    }
}

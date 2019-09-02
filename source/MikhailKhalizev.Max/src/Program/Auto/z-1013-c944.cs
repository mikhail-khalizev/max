using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c944-83eaa10b")]
        public void Method_1013_c944()
        {
            ii(0x1013_c944, 5); push(0x28);                             /* push 0x28 */
            ii(0x1013_c949, 5); call(Definitions.sys_check_available_stack_size, 0x2_9404); /* call 0x10165d52 */
            ii(0x1013_c94e, 1); push(ebx);                              /* push ebx */
            ii(0x1013_c94f, 1); push(ecx);                              /* push ecx */
            ii(0x1013_c950, 1); push(edx);                              /* push edx */
            ii(0x1013_c951, 1); push(esi);                              /* push esi */
            ii(0x1013_c952, 1); push(edi);                              /* push edi */
            ii(0x1013_c953, 1); push(ebp);                              /* push ebp */
            ii(0x1013_c954, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c956, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_c95c, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1013_c95f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c962, 4); mov(memb[ds, eax + 0x20], 0);           /* mov byte [eax+0x20], 0x0 */
            ii(0x1013_c966, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c969, 10); mov(memd[ds, eax + 0xda9], 0xffff);    /* mov dword [eax+0xda9], 0xffff */
            ii(0x1013_c973, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c976, 7); mov(memd[ds, eax + 4], 0);              /* mov dword [eax+0x4], 0x0 */
            ii(0x1013_c97d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c980, 6); mov(memw[ds, eax + 0x10], 0xffff);      /* mov word [eax+0x10], 0xffff */
            ii(0x1013_c986, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c989, 6); mov(memd[ds, eax], 0);                  /* mov dword [eax], 0x0 */
            ii(0x1013_c98f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c992, 7); mov(memd[ds, eax + 8], 0);              /* mov dword [eax+0x8], 0x0 */
            ii(0x1013_c999, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c99c, 6); mov(memw[ds, eax + 0xc], 0xffff);       /* mov word [eax+0xc], 0xffff */
            ii(0x1013_c9a2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c9a5, 6); mov(memw[ds, eax + 0xe], 0xffff);       /* mov word [eax+0xe], 0xffff */
            ii(0x1013_c9ab, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c9ae, 10); mov(memd[ds, eax + 0xdc5], 0);         /* mov dword [eax+0xdc5], 0x0 */
            ii(0x1013_c9b8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c9bb, 10); mov(memd[ds, eax + 0xdca], 0);         /* mov dword [eax+0xdca], 0x0 */
            ii(0x1013_c9c5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c9c8, 10); mov(memd[ds, eax + 0xdce], 0);         /* mov dword [eax+0xdce], 0x0 */
            ii(0x1013_c9d2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c9d5, 4); mov(memb[ds, eax + 0x16], 0);           /* mov byte [eax+0x16], 0x0 */
            ii(0x1013_c9d9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c9dc, 4); mov(memb[ds, eax + 0x17], 0);           /* mov byte [eax+0x17], 0x0 */
            ii(0x1013_c9e0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c9e3, 7); mov(memd[ds, eax + 0x1c], 0xffff);      /* mov dword [eax+0x1c], 0xffff */
            ii(0x1013_c9ea, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c9ed, 10); mov(memd[ds, eax + 0xda5], 0);         /* mov dword [eax+0xda5], 0x0 */
            ii(0x1013_c9f7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c9fa, 10); mov(memd[ds, eax + 0xdad], 0);         /* mov dword [eax+0xdad], 0x0 */
            ii(0x1013_ca04, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_ca07, 7); mov(memb[ds, eax + 0xdd2], 0);          /* mov byte [eax+0xdd2], 0x0 */
            ii(0x1013_ca0e, 7); mov(memd[ss, ebp - 8], 0x14);           /* mov dword [ebp-0x8], 0x14 */
        l_0x1013_ca15:
            ii(0x1013_ca15, 3); dec(memd[ss, ebp - 8]);                 /* dec dword [ebp-0x8] */
            ii(0x1013_ca18, 5); cmp(memw[ss, ebp - 8], -1 /* 0xff */);  /* cmp word [ebp-0x8], 0xffff */
            ii(0x1013_ca1d, 2); if(jz(0x1013_ca5c, 0x3d)) goto l_0x1013_ca5c; /* jz 0x1013ca5c */
            ii(0x1013_ca1f, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1013_ca23, 6); imul(eax, eax, 0x91);                   /* imul eax, eax, 0x91 */
            ii(0x1013_ca29, 3); add(eax, memd[ss, ebp - 4]);            /* add eax, [ebp-0x4] */
            ii(0x1013_ca2c, 10); mov(memd[ds, eax + 0x251], 0xffff);    /* mov dword [eax+0x251], 0xffff */
            ii(0x1013_ca36, 5); mov(ebx, 0x74);                         /* mov ebx, 0x74 */
            ii(0x1013_ca3b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_ca3d, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1013_ca41, 6); imul(eax, eax, 0x91);                   /* imul eax, eax, 0x91 */
            ii(0x1013_ca47, 3); mov(ecx, memd[ss, ebp - 4]);            /* mov ecx, [ebp-0x4] */
            ii(0x1013_ca4a, 6); add(ecx, 0x251);                        /* add ecx, 0x251 */
            ii(0x1013_ca50, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1013_ca52, 3); add(eax, 0xb);                          /* add eax, 0xb */
            ii(0x1013_ca55, 5); call(Definitions.sys_memset, 0x2_9386); /* call 0x10165de0 */
            ii(0x1013_ca5a, 2); jmp(0x1013_ca15, -0x47); goto l_0x1013_ca15; /* jmp 0x1013ca15 */
        l_0x1013_ca5c:
            ii(0x1013_ca5c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_ca5f, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_ca62, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_ca65, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_ca67, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_ca68, 1); pop(edi);                               /* pop edi */
            ii(0x1013_ca69, 1); pop(esi);                               /* pop esi */
            ii(0x1013_ca6a, 1); pop(edx);                               /* pop edx */
            ii(0x1013_ca6b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_ca6c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_ca6d, 1); ret();                                  /* ret */
        }
    }
}

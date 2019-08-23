using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_f504-25b818bd")]
        public void Method_100c_f504()
        {
            ii(0x100c_f504, 5); pushd(0x50);                            /* push 0x50 */
            ii(0x100c_f509, 5); calld(Definitions.sys_check_available_stack_size, 0x9_6844); /* call 0x10165d52 */
            ii(0x100c_f50e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_f50f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_f510, 1); pushd(esi);                             /* push esi */
            ii(0x100c_f511, 1); pushd(edi);                             /* push edi */
            ii(0x100c_f512, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_f513, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_f515, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100c_f51b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_f51e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_f521, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f524, 4); cmp(memd_a32[ds, eax + 0x10], 0);       /* cmp dword [eax+0x10], 0x0 */
            ii(0x100c_f528, 2); if(jzd(0x100c_f554, 0x2a)) goto l_0x100c_f554; /* jz 0x100cf554 */
            ii(0x100c_f52a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f52d, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x100c_f530, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100c_f533, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100c_f537, 2); if(jzd(0x100c_f54d, 0x14)) goto l_0x100c_f54d; /* jz 0x100cf54d */
            ii(0x100c_f539, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_f53b, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100c_f53e, 5); calld(Definitions.my_dtor_d3, 0x87f0);  /* call 0x100d7d33 */
            ii(0x100c_f543, 5); calld(Definitions.sys_delete, 0x9_6a1c); /* call 0x10165f64 */
            ii(0x100c_f548, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100c_f54b, 2); jmpd(0x100c_f554, 0x7); goto l_0x100c_f554; /* jmp 0x100cf554 */
        l_0x100c_f54d:
            ii(0x100c_f54d, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
        l_0x100c_f554:
            ii(0x100c_f554, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100c_f559, 5); calld(Definitions.sys_new, 0x9_68a2);   /* call 0x10165e00 */
            ii(0x100c_f55e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_f561, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_f564, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_f567, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100c_f56b, 2); if(jzd(0x100c_f5a5, 0x38)) goto l_0x100c_f5a5; /* jz 0x100cf5a5 */
            ii(0x100c_f56d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f570, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100c_f573, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_f576, 1); pushd(eax);                             /* push eax */
            ii(0x100c_f577, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f57a, 3); mov(ecx, memd_a32[ds, eax + 0x6]);      /* mov ecx, [eax+0x6] */
            ii(0x100c_f57d, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_f580, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f583, 3); mov(ebx, memd_a32[ds, eax + 0x4]);      /* mov ebx, [eax+0x4] */
            ii(0x100c_f586, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_f589, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f58c, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100c_f58f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_f592, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_f595, 5); calld(0x100d_7bdc, 0x8642);             /* call 0x100d7bdc */
            ii(0x100c_f59a, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100c_f59d, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_f5a0, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100c_f5a3, 2); jmpd(0x100c_f5ab, 0x6); goto l_0x100c_f5ab; /* jmp 0x100cf5ab */
        l_0x100c_f5a5:
            ii(0x100c_f5a5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_f5a8, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x100c_f5ab:
            ii(0x100c_f5ab, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100c_f5ae, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_f5b1, 3); mov(memd_a32[ds, edx + 0x10], eax);     /* mov [edx+0x10], eax */
            ii(0x100c_f5b4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f5b7, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100c_f5ba, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_f5bd, 1); pushd(eax);                             /* push eax */
            ii(0x100c_f5be, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f5c1, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x100c_f5c4, 5); calld(0x100d_4e8c, 0x58c3);             /* call 0x100d4e8c */
            ii(0x100c_f5c9, 1); pushd(eax);                             /* push eax */
            ii(0x100c_f5ca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f5cd, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100c_f5d0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_f5d3, 1); pushd(eax);                             /* push eax */
            ii(0x100c_f5d4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f5d7, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100c_f5da, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_f5dd, 1); pushd(eax);                             /* push eax */
            ii(0x100c_f5de, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f5e1, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100c_f5e4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_f5e7, 1); pushd(eax);                             /* push eax */
            ii(0x100c_f5e8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_f5eb, 1); pushd(eax);                             /* push eax */
            ii(0x100c_f5ec, 5); calld(/* sys */ 0x1016_abbc, 0x9_b5cb); /* call 0x1016abbc */
            ii(0x100c_f5f1, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x100c_f5f4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_f5f6, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_f5f7, 1); popd(edi);                              /* pop edi */
            ii(0x100c_f5f8, 1); popd(esi);                              /* pop esi */
            ii(0x100c_f5f9, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_f5fa, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_f5fb, 1); retd();                                 /* ret */
        }
    }
}

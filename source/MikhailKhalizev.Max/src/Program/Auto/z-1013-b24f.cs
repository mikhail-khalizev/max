using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("43a33ab3-8147-4630-b313-dd7d857844ae")]
        public void Method_1013_b24f()
        {
            ii(0x1013_b24f, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1013_b254, 5); calld(Definitions.sys_check_available_stack_size, 0x2aaf9); /* call 0x10165d52 */
            ii(0x1013_b259, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_b25a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_b25b, 1); pushd(esi);                             /* push esi */
            ii(0x1013_b25c, 1); pushd(edi);                             /* push edi */
            ii(0x1013_b25d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_b25e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b260, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1013_b266, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_b269, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_b26c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_b26f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_b272, 4); cmp(ax, memw_a32[ds, edx + 0x4]);       /* cmp ax, [edx+0x4] */
            ii(0x1013_b276, 2); if(jged(0x1013_b281, 0x9)) goto l_0x1013_b281; /* jge 0x1013b281 */
            ii(0x1013_b278, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1013_b27f, 2); jmpd(0x1013_b29a, 0x19); goto l_0x1013_b29a; /* jmp 0x1013b29a */
        l_0x1013_b281:
            ii(0x1013_b281, 5); mov(ecx, 0x4c);                         /* mov ecx, 0x4c */
            ii(0x1013_b286, 5); mov(ebx, StringDefinitions.SmrtarryCpp); /* mov ebx, 0x101acc44 */
            ii(0x1013_b28b, 5); mov(edx, StringDefinitions.IndexLessCount); /* mov edx, 0x101acc51 */
            ii(0x1013_b290, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_b292, 5); calld(Definitions.sys_assert, 0x2aafb); /* call 0x10165d92 */
            ii(0x1013_b297, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1013_b29a:
            ii(0x1013_b29a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_b29d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_b2a0, 2); jmpd(0x1013_b2a8, 0x6); goto l_0x1013_b2a8; /* jmp 0x1013b2a8 */
        l_0x1013_b2a2:
            ii(0x1013_b2a2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_b2a5, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x1013_b2a8:
            ii(0x1013_b2a8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b2ab, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x1013_b2ae, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_b2b1, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1013_b2b5, 1); dec(eax);                               /* dec eax */
            ii(0x1013_b2b6, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1013_b2b8, 2); if(jged(0x1013_b2e4, 0x2a)) goto l_0x1013_b2e4; /* jge 0x1013b2e4 */
            ii(0x1013_b2ba, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1013_b2be, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1013_b2c1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b2c4, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1013_b2c7, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x1013_b2ca, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_b2cc, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1013_b2d0, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_b2d3, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_b2d5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b2d8, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1013_b2db, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1013_b2dd, 5); calld(0x1013_acc5, -0x61d);             /* call 0x1013acc5 */
            ii(0x1013_b2e2, 2); jmpd(0x1013_b2a2, -0x42); goto l_0x1013_b2a2; /* jmp 0x1013b2a2 */
        l_0x1013_b2e4:
            ii(0x1013_b2e4, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1013_b2e7, 5); calld(Definitions.my_ctor_0x101b6edc, -0xc44a8); /* call 0x10076e44 */
            ii(0x1013_b2ec, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_b2ee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b2f1, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x1013_b2f4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_b2f7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_b2fa, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1013_b2fc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b2ff, 3); mov(ebx, memd_a32[ds, eax + 0x6]);      /* mov ebx, [eax+0x6] */
            ii(0x1013_b302, 3); lea(eax, ecx - 0x4);                    /* lea eax, [ecx-0x4] */
            ii(0x1013_b305, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1013_b307, 5); calld(0x1013_acc5, -0x647);             /* call 0x1013acc5 */
            ii(0x1013_b30c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_b30e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1013_b311, 5); calld(Definitions.my_dtor_0x101b6edc, -0x6d1); /* call 0x1013ac45 */
            ii(0x1013_b316, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b319, 4); dec(memw_a32[ds, eax + 0x4]);           /* dec word [eax+0x4] */
            ii(0x1013_b31d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b31f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_b320, 1); popd(edi);                              /* pop edi */
            ii(0x1013_b321, 1); popd(esi);                              /* pop esi */
            ii(0x1013_b322, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_b323, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_b324, 1); retd(); return;                         /* ret */
        }
    }
}

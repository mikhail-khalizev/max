using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_944a-c16c94c1")]
        public void Method_1015_944a()
        {
            ii(0x1015_944a, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1015_944f, 5); calld(Definitions.sys_check_available_stack_size, 0xc8fe); /* call 0x10165d52 */
            ii(0x1015_9454, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_9455, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_9456, 1); pushd(esi);                             /* push esi */
            ii(0x1015_9457, 1); pushd(edi);                             /* push edi */
            ii(0x1015_9458, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_9459, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_945b, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1015_9461, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_9464, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_9467, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_946a, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_946d, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_9472, 5); calld(0x100f_448c, -0x6_4feb);          /* call 0x100f448c */
            ii(0x1015_9477, 5); calld(0x100f_fc13, -0x5_9869);          /* call 0x100ffc13 */
            ii(0x1015_947c, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_947f, 5); calld(0x1007_611c, -0xe_3368);          /* call 0x1007611c */
            ii(0x1015_9484, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_9487, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_948a, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1015_948e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_9491, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_9494, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1015_9498, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_949b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_949d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_949e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_94a3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_94a4, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_94a9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_94aa, 3); lea(ecx, ebp - 0xc);                    /* lea ecx, [ebp-0xc] */
            ii(0x1015_94ad, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x1015_94b0, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x1015_94b3, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_94b6, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_94b9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_94bc, 5); calld(0x1007_0efa, -0xe_85c7);          /* call 0x10070efa */
            ii(0x1015_94c1, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1015_94c4, 2); if(jnzd(0x1015_94f3, 0x2d)) goto l_0x1015_94f3; /* jnz 0x101594f3 */
            ii(0x1015_94c6, 5); calld(0x100c_aa00, -0x8_eacb);          /* call 0x100caa00 */
            ii(0x1015_94cb, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_94d0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_94d1, 5); calld(0x100c_aa20, -0x8_eab6);          /* call 0x100caa20 */
            ii(0x1015_94d6, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1015_94d8, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_94da, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1015_94df, 5); mov(eax, StringDefinitions.UnableToActivateUnitAtThisSite3); /* mov eax, 0x101b25b1 */
            ii(0x1015_94e4, 5); calld(0x1011_5d23, -0x4_37c6);          /* call 0x10115d23 */
            ii(0x1015_94e9, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_94ec, 5); calld(0x100f_fa70, -0x5_9a81);          /* call 0x100ffa70 */
            ii(0x1015_94f1, 2); jmpd(0x1015_9525, 0x32); goto l_0x1015_9525; /* jmp 0x10159525 */
        l_0x1015_94f3:
            ii(0x1015_94f3, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_94f6, 5); calld(0x1014_f12b, -0xa3d0);            /* call 0x1014f12b */
            ii(0x1015_94fb, 5); calld(0x100c_aa00, -0x8_eb00);          /* call 0x100caa00 */
            ii(0x1015_9500, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_9505, 1); pushd(eax);                             /* push eax */
            ii(0x1015_9506, 5); calld(0x100c_aa20, -0x8_eaeb);          /* call 0x100caa20 */
            ii(0x1015_950b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_950d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_950f, 5); mov(esi, StringDefinitions.SelectAnOpenSquareToPlaceUnit2); /* mov esi, 0x101b25d7 */
            ii(0x1015_9514, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1015_9516, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1015_9518, 5); calld(0x1011_5d23, -0x4_37fa);          /* call 0x10115d23 */
            ii(0x1015_951d, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_9520, 5); calld(0x100f_fa70, -0x5_9ab5);          /* call 0x100ffa70 */
        l_0x1015_9525:
            ii(0x1015_9525, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_9527, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_9528, 1); popd(edi);                              /* pop edi */
            ii(0x1015_9529, 1); popd(esi);                              /* pop esi */
            ii(0x1015_952a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_952b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_952c, 1); retd(); return;                         /* ret */
        }
    }
}

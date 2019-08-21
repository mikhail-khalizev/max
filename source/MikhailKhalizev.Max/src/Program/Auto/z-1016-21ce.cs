using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_21ce-9514b8eb")]
        public void Method_1016_21ce()
        {
            ii(0x1016_21ce, 5); mov(eax, StringDefinitions.Activation); /* mov eax, 0x101b293f */
            ii(0x1016_21d3, 5); calld(0x100a_8b4a, -0xb_968e);          /* call 0x100a8b4a */
            ii(0x1016_21d8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_21db, 3); mov(al, memb_a32[ds, eax + 0x3e]);      /* mov al, [eax+0x3e] */
            ii(0x1016_21de, 3); mov(memb_a32[ss, ebp - 0x34], al);      /* mov [ebp-0x34], al */
            ii(0x1016_21e1, 2); jmpd(0x1016_222e, 0x4b); goto l_0x1016_222e; /* jmp 0x1016222e */
        l_0x1016_21e3:
            ii(0x1016_21e3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_21e6, 5); calld(0x1015_fc49, -0x25a2);            /* call 0x1015fc49 */
            ii(0x1016_21eb, 5); jmpd(0x1016_2250, 0x60); goto l_0x1016_2250; /* jmp 0x10162250 */
        l_0x1016_21f0:
            ii(0x1016_21f0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_21f3, 5); calld(0x1007_611c, -0xe_c0dc);          /* call 0x1007611c */
            ii(0x1016_21f8, 5); calld(0x1014_9fa8, -0x1_8255);          /* call 0x10149fa8 */
            ii(0x1016_21fd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2200, 5); cmp(memw_a32[ds, eax + 0x8], 0x31);     /* cmp word [eax+0x8], 0x31 */
            ii(0x1016_2205, 2); if(jnzd(0x1016_2222, 0x1b)) goto l_0x1016_2222; /* jnz 0x10162222 */
            ii(0x1016_2207, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_220a, 4); mov(memb_a32[ds, eax + 0x3e], 0xb);     /* mov byte [eax+0x3e], 0xb */
            ii(0x1016_220e, 5); mov(ebx, 0x24);                         /* mov ebx, 0x24 */
            ii(0x1016_2213, 5); mov(edx, 0x17);                         /* mov edx, 0x17 */
            ii(0x1016_2218, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_221b, 5); calld(0x1016_2f96, 0xd76);              /* call 0x10162f96 */
            ii(0x1016_2220, 2); jmpd(0x1016_2250, 0x2e); goto l_0x1016_2250; /* jmp 0x10162250 */
        l_0x1016_2222:
            ii(0x1016_2222, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2225, 5); calld(0x1015_f933, -0x28f7);            /* call 0x1015f933 */
            ii(0x1016_222a, 2); jmpd(0x1016_2250, 0x24); goto l_0x1016_2250; /* jmp 0x10162250 */
        l_0x1016_222c:
            ii(0x1016_222c, 2); jmpd(0x1016_2250, 0x22); goto l_0x1016_2250; /* jmp 0x10162250 */
        l_0x1016_222e:
            ii(0x1016_222e, 3); mov(al, memb_a32[ss, ebp - 0x34]);      /* mov al, [ebp-0x34] */
            ii(0x1016_2231, 3); mov(memb_a32[ss, ebp - 0x38], al);      /* mov [ebp-0x38], al */
            ii(0x1016_2234, 4); cmp(memb_a32[ss, ebp - 0x38], 0x6);     /* cmp byte [ebp-0x38], 0x6 */
            ii(0x1016_2238, 2); if(jbd(0x1016_2248, 0xe)) goto l_0x1016_2248; /* jb 0x10162248 */
            ii(0x1016_223a, 4); cmp(memb_a32[ss, ebp - 0x38], 0x6);     /* cmp byte [ebp-0x38], 0x6 */
            ii(0x1016_223e, 2); if(jbed(0x1016_21f0, -0x50)) goto l_0x1016_21f0; /* jbe 0x101621f0 */
            ii(0x1016_2240, 4); cmp(memb_a32[ss, ebp - 0x38], 0xb);     /* cmp byte [ebp-0x38], 0xb */
            ii(0x1016_2244, 2); if(jzd(0x1016_2222, -0x24)) goto l_0x1016_2222; /* jz 0x10162222 */
            ii(0x1016_2246, 2); jmpd(0x1016_222c, -0x1c); goto l_0x1016_222c; /* jmp 0x1016222c */
        l_0x1016_2248:
            ii(0x1016_2248, 4); cmp(memb_a32[ss, ebp - 0x38], 0x1);     /* cmp byte [ebp-0x38], 0x1 */
            ii(0x1016_224c, 2); if(jzd(0x1016_21e3, -0x6b)) goto l_0x1016_21e3; /* jz 0x101621e3 */
            ii(0x1016_224e, 2); jmpd(0x1016_222c, -0x24); goto l_0x1016_222c; /* jmp 0x1016222c */
        l_0x1016_2250:
            ii(0x1016_2250, 5); if(jmpd_func(0x1016_29a7, 0x752)) return; /* jmp 0x101629a7 */
        }
    }
}

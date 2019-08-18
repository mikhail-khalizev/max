using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_00af-e2480990")]
        public void Method_1009_00af()
        {
            ii(0x1009_00af, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_00b4, 5); calld(Definitions.sys_check_available_stack_size, 0xd_5c99); /* call 0x10165d52 */
            ii(0x1009_00b9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_00ba, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_00bb, 1); pushd(esi);                             /* push esi */
            ii(0x1009_00bc, 1); pushd(edi);                             /* push edi */
            ii(0x1009_00bd, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_00be, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_00c0, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_00c6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_00c9, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_00cc, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_00cf, 3); add(edx, 0x15);                         /* add edx, 0x15 */
            ii(0x1009_00d2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_00d5, 5); calld(0x1007_6d98, -0x1_9342);          /* call 0x10076d98 */
            ii(0x1009_00da, 2); test(al, al);                           /* test al, al */
            ii(0x1009_00dc, 2); if(jzd(0x1009_00f8, 0x1a)) goto l_0x1009_00f8; /* jz 0x100900f8 */
            ii(0x1009_00de, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_00e0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_00e3, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_00e6, 5); calld(0x1007_6630, -0x1_9abb);          /* call 0x10076630 */
            ii(0x1009_00eb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_00ed, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_00f0, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1009_00f3, 5); calld(0x1009_c8f8, 0xc800);             /* call 0x1009c8f8 */
        l_0x1009_00f8:
            ii(0x1009_00f8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_00fa, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_00fb, 1); popd(edi);                              /* pop edi */
            ii(0x1009_00fc, 1); popd(esi);                              /* pop esi */
            ii(0x1009_00fd, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_00fe, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_00ff, 1); retd(); return;                         /* ret */
        }
    }
}

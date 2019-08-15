using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b5a1137f-3b15-40d2-9269-f71c6662a499")]
        public void Method_1011_b9e1()
        {
            ii(0x1011_b9e1, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1011_b9e6, 5); calld(Definitions.sys_check_available_stack_size, 0x4_a367); /* call 0x10165d52 */
            ii(0x1011_b9eb, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_b9ec, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_b9ed, 1); pushd(edx);                             /* push edx */
            ii(0x1011_b9ee, 1); pushd(esi);                             /* push esi */
            ii(0x1011_b9ef, 1); pushd(edi);                             /* push edi */
            ii(0x1011_b9f0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_b9f1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_b9f3, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1011_b9f9, 5); mov(eax, 0x1c);                         /* mov eax, 0x1c */
            ii(0x1011_b9fe, 5); calld(Definitions.sys_new, 0x4_a3fd);   /* call 0x10165e00 */
            ii(0x1011_ba03, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_ba06, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_ba09, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_ba0c, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1011_ba10, 2); if(jzd(0x1011_ba25, 0x13)) goto l_0x1011_ba25; /* jz 0x1011ba25 */
            ii(0x1011_ba12, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_ba15, 5); calld(0x1011_9ee6, -0x1b34);            /* call 0x10119ee6 */
            ii(0x1011_ba1a, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_ba1d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_ba20, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_ba23, 2); jmpd(0x1011_ba2b, 0x6); goto l_0x1011_ba2b; /* jmp 0x1011ba2b */
        l_0x1011_ba25:
            ii(0x1011_ba25, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_ba28, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x1011_ba2b:
            ii(0x1011_ba2b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_ba2e, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_ba31, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_ba34, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_ba36, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_ba37, 1); popd(edi);                              /* pop edi */
            ii(0x1011_ba38, 1); popd(esi);                              /* pop esi */
            ii(0x1011_ba39, 1); popd(edx);                              /* pop edx */
            ii(0x1011_ba3a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_ba3b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_ba3c, 1); retd(); return;                         /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("38a13b81-73fe-4e73-b5fa-9bb6471727f7")]
        public void Method_1011_74f2()
        {
            ii(0x1011_74f2, 5); pushd(0x64);                            /* push 0x64 */
            ii(0x1011_74f7, 5); calld(Definitions.sys_check_available_stack_size, 0x4e856); /* call 0x10165d52 */
            ii(0x1011_74fc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_74fd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_74fe, 1); pushd(edx);                             /* push edx */
            ii(0x1011_74ff, 1); pushd(esi);                             /* push esi */
            ii(0x1011_7500, 1); pushd(edi);                             /* push edi */
            ii(0x1011_7501, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_7502, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_7504, 6); sub(esp, 0x48);                         /* sub esp, 0x48 */
            ii(0x1011_750a, 5); calld(0x1012_9753, 0x12244);            /* call 0x10129753 */
            ii(0x1011_750f, 4); or(memb_a32[ss, ebp - 0x4], 0x1);       /* or byte [ebp-0x4], 0x1 */
            ii(0x1011_7513, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1011_7516, 5); calld(0x1011_709a, -0x481);             /* call 0x1011709a */
            ii(0x1011_751b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_751e, 4); and(memb_a32[ss, ebp - 0x4], -0x2 /* 0xfe */); /* and byte [ebp-0x4], 0xfe */
            ii(0x1011_7522, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1011_7525, 5); calld(0x1011_73eb, -0x13f);             /* call 0x101173eb */
            ii(0x1011_752a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_752d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_752f, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1011_7532, 5); calld(0x1011_7319, -0x21e);             /* call 0x10117319 */
            ii(0x1011_7537, 2); jmpd(0x1011_7543, 0xa); goto l_0x1011_7543; /* jmp 0x10117543 */
        //  ii(0x1011_7539, 10); Недостижимый код.
l_0x1011_7543:
            ii(0x1011_7543, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_7546, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_7548, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_7549, 1); popd(edi);                              /* pop edi */
            ii(0x1011_754a, 1); popd(esi);                              /* pop esi */
            ii(0x1011_754b, 1); popd(edx);                              /* pop edx */
            ii(0x1011_754c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_754d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_754e, 1); retd(); return;                         /* ret */
        }
    }
}
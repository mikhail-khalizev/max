using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_6562-c3a4c79c")]
        public void Method_1014_6562()
        {
            ii(0x1014_6562, 5); push(0x30);                             /* push 0x30 */
            ii(0x1014_6567, 5); call(Definitions.sys_check_available_stack_size, 0x1_f7e6); /* call 0x10165d52 */
            ii(0x1014_656c, 1); push(ebx);                              /* push ebx */
            ii(0x1014_656d, 1); push(ecx);                              /* push ecx */
            ii(0x1014_656e, 1); push(edx);                              /* push edx */
            ii(0x1014_656f, 1); push(esi);                              /* push esi */
            ii(0x1014_6570, 1); push(edi);                              /* push edi */
            ii(0x1014_6571, 1); push(ebp);                              /* push ebp */
            ii(0x1014_6572, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_6574, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1014_657a, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_657d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_6580, 5); call(0x1013_b8e1, -0xaca4);             /* call 0x1013b8e1 */
            ii(0x1014_6585, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_6588, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1014_658b, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_658e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_6591, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1014_6594, 5); call(0x100e_0720, -0x6_5e79);           /* call 0x100e0720 */
            ii(0x1014_6599, 3); sub(eax, 0xe);                          /* sub eax, 0xe */
            ii(0x1014_659c, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_659f, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1014_65a2, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_65a5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_65a8, 3); add(eax, 0x12);                         /* add eax, 0x12 */
            ii(0x1014_65ab, 5); call(0x1014_784c, 0x129c);              /* call 0x1014784c */
            ii(0x1014_65b0, 3); sub(eax, 0x12);                         /* sub eax, 0x12 */
            ii(0x1014_65b3, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_65b6, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1014_65b9, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_65bc, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_65bf, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_65c2, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_65c5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_65c7, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_65c8, 1); pop(edi);                               /* pop edi */
            ii(0x1014_65c9, 1); pop(esi);                               /* pop esi */
            ii(0x1014_65ca, 1); pop(edx);                               /* pop edx */
            ii(0x1014_65cb, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_65cc, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_65cd, 1); ret();                                  /* ret */
        }
    }
}

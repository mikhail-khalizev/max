using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6574-610590ec")]
        public void Method_1007_6574()
        {
            ii(0x1007_6574, 5); push(0x28);                             /* push 0x28 */
            ii(0x1007_6579, 5); call(Definitions.sys_check_available_stack_size, 0xe_f7d4); /* call 0x10165d52 */
            ii(0x1007_657e, 1); push(ebx);                              /* push ebx */
            ii(0x1007_657f, 1); push(ecx);                              /* push ecx */
            ii(0x1007_6580, 1); push(edx);                              /* push edx */
            ii(0x1007_6581, 1); push(esi);                              /* push esi */
            ii(0x1007_6582, 1); push(edi);                              /* push edi */
            ii(0x1007_6583, 1); push(ebp);                              /* push ebp */
            ii(0x1007_6584, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6586, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_658c, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_658f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_6592, 3); cmp(memd[ds, eax], 0);                  /* cmp dword [eax], 0x0 */
            ii(0x1007_6595, 2); if(jz(0x1007_65a0, 9)) goto l_0x1007_65a0; /* jz 0x100765a0 */
            ii(0x1007_6597, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x1007_659e, 2); jmp(0x1007_65b9, 0x19); goto l_0x1007_65b9; /* jmp 0x100765b9 */
        l_0x1007_65a0:
            ii(0x1007_65a0, 5); mov(ecx, 0xae);                         /* mov ecx, 0xae */
            ii(0x1007_65a5, 5); mov(ebx, StringDefinitions.SmartptrH4); /* mov ebx, 0x101a0040 */
            ii(0x1007_65aa, 5); mov(edx, StringDefinitions.PtrNotEqual04); /* mov edx, 0x101a004b */
            ii(0x1007_65af, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_65b1, 5); call(Definitions.sys_assert, 0xe_f7dc); /* call 0x10165d92 */
            ii(0x1007_65b6, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x1007_65b9:
            ii(0x1007_65b9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_65bc, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1007_65be, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_65c1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_65c4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_65c6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_65c7, 1); pop(edi);                               /* pop edi */
            ii(0x1007_65c8, 1); pop(esi);                               /* pop esi */
            ii(0x1007_65c9, 1); pop(edx);                               /* pop edx */
            ii(0x1007_65ca, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_65cb, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_65cc, 1); ret();                                  /* ret */
        }
    }
}

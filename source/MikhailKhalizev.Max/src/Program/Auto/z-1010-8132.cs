using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_8132-fb0b0bc0")]
        public void Method_1010_8132()
        {
            ii(0x1010_8132, 5); push(0x28);                             /* push 0x28 */
            ii(0x1010_8137, 5); call(Definitions.sys_check_available_stack_size, 0x5_dc16); /* call 0x10165d52 */
            ii(0x1010_813c, 1); push(ebx);                              /* push ebx */
            ii(0x1010_813d, 1); push(ecx);                              /* push ecx */
            ii(0x1010_813e, 1); push(esi);                              /* push esi */
            ii(0x1010_813f, 1); push(edi);                              /* push edi */
            ii(0x1010_8140, 1); push(ebp);                              /* push ebp */
            ii(0x1010_8141, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_8143, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1010_8149, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_814c, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_814f, 3); lea(edi, memd[ss, ebp - 0x10]);         /* lea edi, [ebp-0x10] */
            ii(0x1010_8152, 5); mov(esi, 0x101b_9010);                  /* mov esi, 0x101b9010 */
            ii(0x1010_8157, 1); movsd();                                /* movsd */
            ii(0x1010_8158, 2); movsw();                                /* movsw */
            ii(0x1010_815a, 7); cmp(memd[ds, 0x101c_4db8], 0);          /* cmp dword [0x101c4db8], 0x0 */
            ii(0x1010_8161, 2); if(jz(0x1010_817a, 0x17)) goto l_0x1010_817a; /* jz 0x1010817a */
            ii(0x1010_8163, 5); mov(ecx, 0x101c_4dc0);                  /* mov ecx, 0x101c4dc0 */
            ii(0x1010_8168, 5); mov(ebx, 0x101c_4dbc);                  /* mov ebx, 0x101c4dbc */
            ii(0x1010_816d, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_8170, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_8173, 5); call(0x1010_8192, 0x1a);                /* call 0x10108192 */
            ii(0x1010_8178, 2); jmp(0x1010_818a, 0x10); goto l_0x1010_818a; /* jmp 0x1010818a */
        l_0x1010_817a:
            ii(0x1010_817a, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_817c, 3); lea(ebx, memd[ss, ebp - 0x10]);         /* lea ebx, [ebp-0x10] */
            ii(0x1010_817f, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_8182, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_8185, 5); call(0x1010_7e6a, -0x320);              /* call 0x10107e6a */
        l_0x1010_818a:
            ii(0x1010_818a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_818c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_818d, 1); pop(edi);                               /* pop edi */
            ii(0x1010_818e, 1); pop(esi);                               /* pop esi */
            ii(0x1010_818f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_8190, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_8191, 1); ret();                                  /* ret */
        }
    }
}

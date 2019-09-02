using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_0aa5-e60468bb")]
        public void Method_100a_0aa5()
        {
            ii(0x100a_0aa5, 5); push(0x28);                             /* push 0x28 */
            ii(0x100a_0aaa, 5); call(Definitions.sys_check_available_stack_size, 0xc_52a3); /* call 0x10165d52 */
            ii(0x100a_0aaf, 1); push(ecx);                              /* push ecx */
            ii(0x100a_0ab0, 1); push(esi);                              /* push esi */
            ii(0x100a_0ab1, 1); push(edi);                              /* push edi */
            ii(0x100a_0ab2, 1); push(ebp);                              /* push ebp */
            ii(0x100a_0ab3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_0ab5, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100a_0abb, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_0abe, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100a_0ac1, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x100a_0ac4, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_0ac7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_0aca, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_0acd, 5); call(0x100a_098c, -0x146);              /* call 0x100a098c */
            ii(0x100a_0ad2, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_0ad5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_0ad8, 3); cmp(eax, memd[ss, ebp - 0x10]);         /* cmp eax, [ebp-0x10] */
            ii(0x100a_0adb, 2); if(jle(0x100a_0ae3, 6)) goto l_0x100a_0ae3; /* jle 0x100a0ae3 */
            ii(0x100a_0add, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0ae0, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
        l_0x100a_0ae3:
            ii(0x100a_0ae3, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_0ae6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_0ae9, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x100a_0aec, 5); call(0x100a_098c, -0x165);              /* call 0x100a098c */
            ii(0x100a_0af1, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_0af4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_0af7, 3); cmp(eax, memd[ss, ebp - 0x10]);         /* cmp eax, [ebp-0x10] */
            ii(0x100a_0afa, 2); if(jle(0x100a_0b02, 6)) goto l_0x100a_0b02; /* jle 0x100a0b02 */
            ii(0x100a_0afc, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0aff, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
        l_0x100a_0b02:
            ii(0x100a_0b02, 4); cmp(memd[ss, ebp - 4], 0);              /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100a_0b06, 2); if(jg(0x100a_0b11, 9)) goto l_0x100a_0b11; /* jg 0x100a0b11 */
            ii(0x100a_0b08, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x100a_0b0f, 2); jmp(0x100a_0b3d, 0x2c); goto l_0x100a_0b3d; /* jmp 0x100a0b3d */
        l_0x100a_0b11:
            ii(0x100a_0b11, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x100a_0b14, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_0b17, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_0b1a, 3); add(eax, 2);                            /* add eax, 0x2 */
            ii(0x100a_0b1d, 5); call(0x1007_68e0, -0x2_a242);           /* call 0x100768e0 */
            ii(0x100a_0b22, 5); call(0x1014_3b69, 0xa_3042);            /* call 0x10143b69 */
            ii(0x100a_0b27, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x100a_0b2a, 2); neg(ebx);                               /* neg ebx */
            ii(0x100a_0b2c, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_0b2f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_0b32, 5); call(0x100a_0a0a, -0x12d);              /* call 0x100a0a0a */
            ii(0x100a_0b37, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_0b3a, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
        l_0x100a_0b3d:
            ii(0x100a_0b3d, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100a_0b40, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_0b42, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_0b43, 1); pop(edi);                               /* pop edi */
            ii(0x100a_0b44, 1); pop(esi);                               /* pop esi */
            ii(0x100a_0b45, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_0b46, 1); ret();                                  /* ret */
        }
    }
}

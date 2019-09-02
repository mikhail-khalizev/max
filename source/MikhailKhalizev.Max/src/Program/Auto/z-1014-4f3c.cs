using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_4f3c-30c4765a")]
        public void Method_1014_4f3c()
        {
            ii(0x1014_4f3c, 5); push(0x30);                             /* push 0x30 */
            ii(0x1014_4f41, 5); call(Definitions.sys_check_available_stack_size, 0x2_0e0c); /* call 0x10165d52 */
            ii(0x1014_4f46, 1); push(ecx);                              /* push ecx */
            ii(0x1014_4f47, 1); push(esi);                              /* push esi */
            ii(0x1014_4f48, 1); push(edi);                              /* push edi */
            ii(0x1014_4f49, 1); push(ebp);                              /* push ebp */
            ii(0x1014_4f4a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_4f4c, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1014_4f52, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_4f55, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1014_4f58, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1014_4f5b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_4f5e, 5); call(0x1013_aaa8, -0xa4bb);             /* call 0x1013aaa8 */
            ii(0x1014_4f63, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_4f66, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1014_4f69, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_4f6c, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_4f6f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_4f72, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x1014_4f75, 5); call(Definitions.my_string_ctor_string, -0x34d4); /* call 0x10141aa6 */
            ii(0x1014_4f7a, 3); sub(eax, 6);                            /* sub eax, 0x6 */
            ii(0x1014_4f7d, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_4f80, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1014_4f83, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_4f86, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_4f89, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_4f8c, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1014_4f8f, 5); call(0x1014_77f0, 0x285c);              /* call 0x101477f0 */
            ii(0x1014_4f94, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x1014_4f97, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_4f9a, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1014_4f9d, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_4fa0, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_4fa3, 7); mov(memd[ds, eax + 2], 0x101b_727c);    /* mov dword [eax+0x2], 0x101b727c */
            ii(0x1014_4faa, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_4fad, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1014_4fb0, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1014_4fb3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_4fb5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_4fb6, 1); pop(edi);                               /* pop edi */
            ii(0x1014_4fb7, 1); pop(esi);                               /* pop esi */
            ii(0x1014_4fb8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_4fb9, 1); ret();                                  /* ret */
        }
    }
}

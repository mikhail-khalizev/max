using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_4d50-52555c4d")]
        public void Method_100a_4d50()
        {
            ii(0x100a_4d50, 5); push(0x28);                             /* push 0x28 */
            ii(0x100a_4d55, 5); call(Definitions.sys_check_available_stack_size, 0xc_0ff8); /* call 0x10165d52 */
            ii(0x100a_4d5a, 1); push(ebx);                              /* push ebx */
            ii(0x100a_4d5b, 1); push(ecx);                              /* push ecx */
            ii(0x100a_4d5c, 1); push(esi);                              /* push esi */
            ii(0x100a_4d5d, 1); push(edi);                              /* push edi */
            ii(0x100a_4d5e, 1); push(ebp);                              /* push ebp */
            ii(0x100a_4d5f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_4d61, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_4d67, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_4d6a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_4d6d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_4d70, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_4d73, 5); call(0x1009_ca40, -0x8338);             /* call 0x1009ca40 */
            ii(0x100a_4d78, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_4d7b, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100a_4d7e, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_4d81, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100a_4d84, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_4d87, 3); call_abs(memd[ds, edx + 32]);           /* call dword [edx+0x20] */
            ii(0x100a_4d8a, 2); cmp(al, 0x19);                          /* cmp al, 0x19 */
            ii(0x100a_4d8c, 2); if(jnz(0x100a_4d9c, 0xe)) goto l_0x100a_4d9c; /* jnz 0x100a4d9c */
            ii(0x100a_4d8e, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_4d91, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_4d94, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x100a_4d97, 5); call(0x100a_b07c, 0x62e0);              /* call 0x100ab07c */
        l_0x100a_4d9c:
            ii(0x100a_4d9c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_4d9f, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_4da2, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_4da5, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100a_4da8, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_4dab, 3); call_abs(memd[ds, edx + 48]);           /* call dword [edx+0x30] */
            ii(0x100a_4dae, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_4db0, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_4db1, 1); pop(edi);                               /* pop edi */
            ii(0x100a_4db2, 1); pop(esi);                               /* pop esi */
            ii(0x100a_4db3, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_4db4, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_4db5, 1); ret();                                  /* ret */
        }
    }
}

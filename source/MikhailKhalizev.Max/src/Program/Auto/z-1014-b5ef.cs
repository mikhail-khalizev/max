using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_b5ef-c455ffc2")]
        public void Method_1014_b5ef()
        {
            ii(0x1014_b5ef, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1014_b5f4, 5);  call(Definitions.sys_check_available_stack_size, 0x1_a759);/* call 0x10165d52 */
            ii(0x1014_b5f9, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_b5fa, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_b5fb, 1);  push(edx);                            /* push edx */
            ii(0x1014_b5fc, 1);  push(esi);                            /* push esi */
            ii(0x1014_b5fd, 1);  push(edi);                            /* push edi */
            ii(0x1014_b5fe, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_b5ff, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_b601, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1014_b607, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_b60a, 5);  mov(eax, 0xa);                        /* mov eax, 0xa */
            ii(0x1014_b60f, 5);  call(Definitions.sys_new, 0x1_a7ec);  /* call 0x10165e00 */
            ii(0x1014_b614, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_b617, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_b61a, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_b61d, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1014_b621, 2);  if(jz(0x1014_b636, 0x13)) goto l_0x1014_b636;/* jz 0x1014b636 */
            ii(0x1014_b623, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_b626, 5);  call(Definitions.my_ctor_0x101b_56fc, -0xc_29af);/* call 0x10088c7c */
            ii(0x1014_b62b, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_b62e, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_b631, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_b634, 2);  jmp(0x1014_b63c, 6); goto l_0x1014_b63c;/* jmp 0x1014b63c */
        l_0x1014_b636:
            ii(0x1014_b636, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_b639, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x1014_b63c:
            ii(0x1014_b63c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_b63f, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_b642, 3);  mov(memd[ds, edx + 126], eax);        /* mov [edx+0x7e], eax */
            ii(0x1014_b645, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_b647, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_b648, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_b649, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_b64a, 1);  pop(edx);                             /* pop edx */
            ii(0x1014_b64b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_b64c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_b64d, 1);  ret();                                /* ret */
        }
    }
}

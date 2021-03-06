using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_5a6b-ce104c98")]
        public void Method_1014_5a6b()
        {
            ii(0x1014_5a6b, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1014_5a70, 5);  call(Definitions.sys_check_available_stack_size, 0x2_02dd);/* call 0x10165d52 */
            ii(0x1014_5a75, 1);  push(esi);                            /* push esi */
            ii(0x1014_5a76, 1);  push(edi);                            /* push edi */
            ii(0x1014_5a77, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_5a78, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_5a7a, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x1014_5a80, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_5a83, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1014_5a86, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1014_5a89, 3);  mov(memb[ss, ebp - 4], cl);           /* mov [ebp-0x4], cl */
            ii(0x1014_5a8c, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1014_5a8f, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1014_5a92, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_5a95, 5);  call(0x1014_4f3c, -0xb5e);            /* call 0x10144f3c */
            ii(0x1014_5a9a, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_5a9d, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1014_5aa0, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_5aa3, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_5aa6, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1014_5aa9, 5);  call(0x100e_0838, -0x6_5276);         /* call 0x100e0838 */
            ii(0x1014_5aae, 3);  sub(eax, 0x18);                       /* sub eax, 0x18 */
            ii(0x1014_5ab1, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_5ab4, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1014_5ab7, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_5aba, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_5abd, 3);  add(eax, 0x1c);                       /* add eax, 0x1c */
            ii(0x1014_5ac0, 5);  call(0x1014_7ed4, 0x240f);            /* call 0x10147ed4 */
            ii(0x1014_5ac5, 3);  sub(eax, 0x1c);                       /* sub eax, 0x1c */
            ii(0x1014_5ac8, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_5acb, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1014_5ace, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1014_5ad1, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_5ad4, 7);  mov(memd[ds, eax + 2], 0x101b_71e4);  /* mov dword [eax+0x2], 0x101b71e4 */
            ii(0x1014_5adb, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x1014_5ade, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1014_5ae1, 3);  mov(memd[ds, edx + 20], eax);         /* mov [edx+0x14], eax */
            ii(0x1014_5ae4, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_5ae7, 4);  mov(memb[ds, eax + 38], 0);           /* mov byte [eax+0x26], 0x0 */
            ii(0x1014_5aeb, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1014_5aee, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1014_5af1, 3);  mov(memb[ds, edx + 39], al);          /* mov [edx+0x27], al */
            ii(0x1014_5af4, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_5af7, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1014_5afa, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1014_5afd, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_5aff, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_5b00, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_5b01, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_5b02, 3);  ret(4);                               /* ret 0x4 */
        }
    }
}

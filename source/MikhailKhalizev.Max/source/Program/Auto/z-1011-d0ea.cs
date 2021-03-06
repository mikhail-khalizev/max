using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_d0ea-a80f7a66")]
        public void Method_1011_d0ea()
        {
            ii(0x1011_d0ea, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1011_d0ef, 5);  call(Definitions.sys_check_available_stack_size, 0x4_8c5e);/* call 0x10165d52 */
            ii(0x1011_d0f4, 1);  push(esi);                            /* push esi */
            ii(0x1011_d0f5, 1);  push(edi);                            /* push edi */
            ii(0x1011_d0f6, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_d0f7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_d0f9, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x1011_d0ff, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_d102, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1011_d105, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1011_d108, 3);  mov(memd[ss, ebp - 8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x1011_d10b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_d10e, 5);  call(0x1013_aaa8, 0x1_d995);          /* call 0x1013aaa8 */
            ii(0x1011_d113, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_d116, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1011_d119, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_d11c, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_d11f, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_d122, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d125, 5);  call(0x1007_66ac, -0xa_6a7e);         /* call 0x100766ac */
            ii(0x1011_d12a, 3);  sub(eax, 6);                          /* sub eax, 0x6 */
            ii(0x1011_d12d, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_d130, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1011_d133, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_d136, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_d139, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_d13c, 3);  add(eax, 0xa);                        /* add eax, 0xa */
            ii(0x1011_d13f, 5);  call(0x1007_5e64, -0xa_72e0);         /* call 0x10075e64 */
            ii(0x1011_d144, 3);  sub(eax, 0xa);                        /* sub eax, 0xa */
            ii(0x1011_d147, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_d14a, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1011_d14d, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1011_d150, 3);  mov(memb[ds, edx + 14], al);          /* mov [edx+0xe], al */
            ii(0x1011_d153, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_d156, 3);  add(eax, 0x16);                       /* add eax, 0x16 */
            ii(0x1011_d159, 5);  call(Definitions.my_ctor_0x101b_38f8, -0xa_6a6e);/* call 0x100766f0 */
            ii(0x1011_d15e, 3);  sub(eax, 0x16);                       /* sub eax, 0x16 */
            ii(0x1011_d161, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_d164, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1011_d167, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_d16a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_d16d, 7);  mov(memd[ds, eax + 2], 0x101b_68cc);  /* mov dword [eax+0x2], 0x101b68cc */
            ii(0x1011_d174, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_d177, 6);  mov(memw[ds, eax + 15], 0x7fff);      /* mov word [eax+0xf], 0x7fff */
            ii(0x1011_d17d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_d180, 6);  mov(memw[ds, eax + 17], 0);           /* mov word [eax+0x11], 0x0 */
            ii(0x1011_d186, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_d189, 4);  mov(memb[ds, eax + 19], 0);           /* mov byte [eax+0x13], 0x0 */
            ii(0x1011_d18d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_d190, 4);  mov(memb[ds, eax + 20], 0);           /* mov byte [eax+0x14], 0x0 */
            ii(0x1011_d194, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_d197, 4);  mov(memb[ds, eax + 21], 1);           /* mov byte [eax+0x15], 0x1 */
            ii(0x1011_d19b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_d19e, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1011_d1a1, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1011_d1a4, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_d1a6, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_d1a7, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_d1a8, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_d1a9, 1);  ret();                                /* ret */
        }
    }
}

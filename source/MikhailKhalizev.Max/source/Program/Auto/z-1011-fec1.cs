using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_fec1-2721601f")]
        public void Method_1011_fec1()
        {
            ii(0x1011_fec1, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1011_fec6, 5);  call(Definitions.sys_check_available_stack_size, 0x4_5e87);/* call 0x10165d52 */
            ii(0x1011_fecb, 1);  push(esi);                            /* push esi */
            ii(0x1011_fecc, 1);  push(edi);                            /* push edi */
            ii(0x1011_fecd, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_fece, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_fed0, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1011_fed6, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_fed9, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1011_fedc, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1011_fedf, 3);  mov(memb[ss, ebp - 8], cl);           /* mov [ebp-0x8], cl */
            ii(0x1011_fee2, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_fee5, 5);  call(0x1008_bbed, -0x9_42fd);         /* call 0x1008bbed */
            ii(0x1011_feea, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_feed, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1011_fef0, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_fef3, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_fef6, 3);  add(eax, 7);                          /* add eax, 0x7 */
            ii(0x1011_fef9, 5);  call(Definitions.my_ctor_0x101b_38f8, -0xa_980e);/* call 0x100766f0 */
            ii(0x1011_fefe, 3);  sub(eax, 7);                          /* sub eax, 0x7 */
            ii(0x1011_ff01, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_ff04, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1011_ff07, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_ff0a, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_ff0d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_ff10, 3);  add(eax, 7);                          /* add eax, 0x7 */
            ii(0x1011_ff13, 5);  call(0x1007_6630, -0xa_98e8);         /* call 0x10076630 */
            ii(0x1011_ff18, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1011_ff1b, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1011_ff1e, 3);  mov(memb[ds, edx + 11], al);          /* mov [edx+0xb], al */
            ii(0x1011_ff21, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1011_ff24, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1011_ff27, 3);  mov(memb[ds, edx + 12], al);          /* mov [edx+0xc], al */
            ii(0x1011_ff2a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_ff2d, 4);  mov(memb[ds, eax + 6], 0);            /* mov byte [eax+0x6], 0x0 */
            ii(0x1011_ff31, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x1011_ff34, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1011_ff37, 4);  mov(memw[ds, edx + 13], ax);          /* mov [edx+0xd], ax */
            ii(0x1011_ff3b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_ff3e, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_ff41, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1011_ff44, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_ff46, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_ff47, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_ff48, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_ff49, 3);  ret(4);                               /* ret 0x4 */
        }
    }
}

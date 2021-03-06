using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_fc73-bbbe0ed2")]
        public void Method_1014_fc73()
        {
            ii(0x1014_fc73, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_fc78, 5);  call(Definitions.sys_check_available_stack_size, 0x1_60d5);/* call 0x10165d52 */
            ii(0x1014_fc7d, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_fc7e, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_fc7f, 1);  push(esi);                            /* push esi */
            ii(0x1014_fc80, 1);  push(edi);                            /* push edi */
            ii(0x1014_fc81, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_fc82, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_fc84, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1014_fc8a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_fc8d, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_fc90, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_fc93, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1014_fc96, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1014_fc99, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x1014_fc9c, 7);  cmp(memb[ds, eax + 0x101c_81d5], 1);  /* cmp byte [eax+0x101c81d5], 0x1 */
            ii(0x1014_fca3, 6);  if(jnz(0x1014_fd37, 0x8e)) goto l_0x1014_fd37;/* jnz 0x1014fd37 */
            ii(0x1014_fca9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_fcac, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_fcaf, 4);  add(memw[ds, edx + 82], ax);          /* add [edx+0x52], ax */
            ii(0x1014_fcb3, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_fcb5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_fcb8, 3);  add(eax, 0x70);                       /* add eax, 0x70 */
            ii(0x1014_fcbb, 5);  call(0x1013_ad71, -0x1_4f4f);         /* call 0x1013ad71 */
            ii(0x1014_fcc0, 2);  test(al, al);                         /* test al, al */
            ii(0x1014_fcc2, 2);  if(jz(0x1014_fd37, 0x73)) goto l_0x1014_fd37;/* jz 0x1014fd37 */
            ii(0x1014_fcc4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_fcc7, 5);  call(0x1007_623c, -0xd_9a90);         /* call 0x1007623c */
            ii(0x1014_fccc, 4);  mov(ax, memw[ds, eax + 25]);          /* mov ax, [eax+0x19] */
            ii(0x1014_fcd0, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_fcd3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_fcd6, 3);  add(eax, 0x70);                       /* add eax, 0x70 */
            ii(0x1014_fcd9, 5);  call(0x1007_6884, -0xd_945a);         /* call 0x10076884 */
            ii(0x1014_fcde, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_fce0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_fce3, 4);  add(memw[ds, edx + 8], ax);           /* add [edx+0x8], ax */
            ii(0x1014_fce7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_fcea, 4);  mov(ax, memw[ds, eax + 82]);          /* mov ax, [eax+0x52] */
            ii(0x1014_fcee, 4);  cmp(ax, memw[ss, ebp - 12]);          /* cmp ax, [ebp-0xc] */
            ii(0x1014_fcf2, 2);  if(jle(0x1014_fd37, 0x43)) goto l_0x1014_fd37;/* jle 0x1014fd37 */
            ii(0x1014_fcf4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_fcf7, 4);  mov(ax, memw[ds, eax + 82]);          /* mov ax, [eax+0x52] */
            ii(0x1014_fcfb, 3);  sub(eax, memd[ss, ebp - 12]);         /* sub eax, [ebp-0xc] */
            ii(0x1014_fcfe, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_fd01, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_fd04, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_fd07, 4);  mov(memw[ds, edx + 82], ax);          /* mov [edx+0x52], ax */
            ii(0x1014_fd0b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_fd0e, 3);  add(eax, 0x70);                       /* add eax, 0x70 */
            ii(0x1014_fd11, 5);  call(0x1007_6884, -0xd_9492);         /* call 0x10076884 */
            ii(0x1014_fd16, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_fd18, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_fd1b, 4);  sub(memw[ds, edx + 8], ax);           /* sub [edx+0x8], ax */
            ii(0x1014_fd1f, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1014_fd21, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1014_fd23, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1014_fd27, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_fd2a, 3);  add(eax, 0x70);                       /* add eax, 0x70 */
            ii(0x1014_fd2d, 5);  call(0x1015_5314, 0x55e2);            /* call 0x10155314 */
            ii(0x1014_fd32, 5);  call(0x100d_7a9c, -0x7_829b);         /* call 0x100d7a9c */
        l_0x1014_fd37:
            ii(0x1014_fd37, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_fd39, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_fd3a, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_fd3b, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_fd3c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_fd3d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_fd3e, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_7ff6-b9101569")]
        public void Method_1007_7ff6()
        {
            ii(0x1007_7ff6, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1007_7ffb, 5);  call(Definitions.sys_check_available_stack_size, 0xe_dd52);/* call 0x10165d52 */
            ii(0x1007_8000, 1);  push(esi);                            /* push esi */
            ii(0x1007_8001, 1);  push(edi);                            /* push edi */
            ii(0x1007_8002, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_8003, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_8005, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1007_800b, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_800e, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1007_8011, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1007_8014, 3);  mov(memb[ss, ebp - 4], cl);           /* mov [ebp-0x4], cl */
            ii(0x1007_8017, 4);  movsx(ebx, memb[ss, ebp - 4]);        /* movsx ebx, byte [ebp-0x4] */
            ii(0x1007_801b, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1007_801e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_8021, 5);  call(0x100c_0532, 0x4_850c);          /* call 0x100c0532 */
            ii(0x1007_8026, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_8029, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1007_802d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_8030, 5);  call(0x1007_7f86, -0xaf);             /* call 0x10077f86 */
            ii(0x1007_8035, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_8038, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1007_803c, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_803e, 2);  if(jle(0x1007_8069, 0x29)) goto l_0x1007_8069;/* jle 0x10078069 */
            ii(0x1007_8040, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_8043, 5);  call(0x1007_623c, -0x1e0c);           /* call 0x1007623c */
            ii(0x1007_8048, 3);  mov(ebx, memd[ds, eax + 6]);          /* mov ebx, [eax+0x6] */
            ii(0x1007_804b, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1007_804e, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1007_8052, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1007_8056, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1007_8059, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1007_805b, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1007_805e, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1007_8060, 4);  movsx(edx, memw[ss, ebp + 16]);       /* movsx edx, word [ebp+0x10] */
            ii(0x1007_8064, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x1007_8066, 3);  mov(memd[ss, ebp + 16], edx);         /* mov [ebp+0x10], edx */
        l_0x1007_8069:
            ii(0x1007_8069, 4);  movsx(eax, memw[ss, ebp + 16]);       /* movsx eax, word [ebp+0x10] */
            ii(0x1007_806d, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_806f, 2);  if(jg(0x1007_807a, 9)) goto l_0x1007_807a;/* jg 0x1007807a */
            ii(0x1007_8071, 7);  mov(memd[ss, ebp + 16], 0);           /* mov dword [ebp+0x10], 0x0 */
            ii(0x1007_8078, 2);  jmp(0x1007_8089, 0xf); goto l_0x1007_8089;/* jmp 0x10078089 */
        l_0x1007_807a:
            ii(0x1007_807a, 4);  movsx(edx, memw[ss, ebp + 16]);       /* movsx edx, word [ebp+0x10] */
            ii(0x1007_807e, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_8081, 5);  call(0x1007_7f86, -0x100);            /* call 0x10077f86 */
            ii(0x1007_8086, 3);  mov(memd[ss, ebp + 16], eax);         /* mov [ebp+0x10], eax */
        l_0x1007_8089:
            ii(0x1007_8089, 4);  cmp(memb[ss, ebp + 20], 0);           /* cmp byte [ebp+0x14], 0x0 */
            ii(0x1007_808d, 2);  if(jz(0x1007_8097, 8)) goto l_0x1007_8097;/* jz 0x10078097 */
            ii(0x1007_808f, 4);  movsx(eax, memw[ss, ebp + 16]);       /* movsx eax, word [ebp+0x10] */
            ii(0x1007_8093, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_8095, 2);  if(jg(0x1007_8099, 2)) goto l_0x1007_8099;/* jg 0x10078099 */
        l_0x1007_8097:
            ii(0x1007_8097, 2);  jmp(0x1007_809f, 6); goto l_0x1007_809f;/* jmp 0x1007809f */
        l_0x1007_8099:
            ii(0x1007_8099, 4);  mov(memb[ss, ebp - 24], 1);           /* mov byte [ebp-0x18], 0x1 */
            ii(0x1007_809d, 2);  jmp(0x1007_80b8, 0x19); goto l_0x1007_80b8;/* jmp 0x100780b8 */
        l_0x1007_809f:
            ii(0x1007_809f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_80a2, 4);  cmp(ax, memw[ss, ebp + 16]);          /* cmp ax, [ebp+0x10] */
            ii(0x1007_80a6, 2);  if(jge(0x1007_80ae, 6)) goto l_0x1007_80ae;/* jge 0x100780ae */
            ii(0x1007_80a8, 4);  mov(memb[ss, ebp - 28], 1);           /* mov byte [ebp-0x1c], 0x1 */
            ii(0x1007_80ac, 2);  jmp(0x1007_80b2, 4); goto l_0x1007_80b2;/* jmp 0x100780b2 */
        l_0x1007_80ae:
            ii(0x1007_80ae, 4);  mov(memb[ss, ebp - 28], 0);           /* mov byte [ebp-0x1c], 0x0 */
        l_0x1007_80b2:
            ii(0x1007_80b2, 3);  mov(al, memb[ss, ebp - 28]);          /* mov al, [ebp-0x1c] */
            ii(0x1007_80b5, 3);  mov(memb[ss, ebp - 24], al);          /* mov [ebp-0x18], al */
        l_0x1007_80b8:
            ii(0x1007_80b8, 3);  mov(al, memb[ss, ebp - 24]);          /* mov al, [ebp-0x18] */
            ii(0x1007_80bb, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_80bd, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_80be, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_80bf, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_80c0, 3);  ret(8);                               /* ret 0x8 */
        }
    }
}

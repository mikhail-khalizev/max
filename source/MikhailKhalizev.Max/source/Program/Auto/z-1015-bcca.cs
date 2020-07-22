using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_bcca-ad198d9f")]
        public void Method_1015_bcca()
        {
            ii(0x1015_bcca, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1015_bccf, 5);  call(Definitions.sys_check_available_stack_size, 0xa07e);/* call 0x10165d52 */
            ii(0x1015_bcd4, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_bcd5, 1);  push(esi);                            /* push esi */
            ii(0x1015_bcd6, 1);  push(edi);                            /* push edi */
            ii(0x1015_bcd7, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_bcd8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_bcda, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1015_bce0, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1015_bce3, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1015_bce6, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1015_bce9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_bcec, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1015_bcef, 4);  mov(memw[ds, edx + 26], ax);          /* mov [edx+0x1a], ax */
            ii(0x1015_bcf3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_bcf6, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1015_bcf9, 4);  mov(memw[ds, edx + 28], ax);          /* mov [edx+0x1c], ax */
            ii(0x1015_bcfd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_bd00, 3);  shl(eax, 6);                          /* shl eax, 0x6 */
            ii(0x1015_bd03, 5);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x1015_bd08, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_bd0b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_bd0e, 3);  shl(eax, 6);                          /* shl eax, 0x6 */
            ii(0x1015_bd11, 5);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x1015_bd16, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_bd19, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_bd1c, 4);  test(memb[ds, eax + 18], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1015_bd20, 2);  if(jz(0x1015_bd2a, 8)) goto l_0x1015_bd2a;/* jz 0x1015bd2a */
            ii(0x1015_bd22, 4);  add(memd[ss, ebp - 8], 0x1f);         /* add dword [ebp-0x8], 0x1f */
            ii(0x1015_bd26, 4);  add(memd[ss, ebp - 4], 0x1f);         /* add dword [ebp-0x4], 0x1f */
        l_0x1015_bd2a:
            ii(0x1015_bd2a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_bd2d, 4);  mov(ax, memw[ds, eax + 22]);          /* mov ax, [eax+0x16] */
            ii(0x1015_bd31, 3);  sub(memd[ss, ebp - 8], eax);          /* sub [ebp-0x8], eax */
            ii(0x1015_bd34, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_bd37, 4);  mov(ax, memw[ds, eax + 24]);          /* mov ax, [eax+0x18] */
            ii(0x1015_bd3b, 3);  sub(memd[ss, ebp - 4], eax);          /* sub [ebp-0x4], eax */
            ii(0x1015_bd3e, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1015_bd42, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1015_bd46, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_bd49, 5);  call(0x1014_9c2f, -0x1_211f);         /* call 0x10149c2f */
            ii(0x1015_bd4e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_bd50, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_bd51, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_bd52, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_bd53, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_bd54, 1);  ret();                                /* ret */
        }
    }
}

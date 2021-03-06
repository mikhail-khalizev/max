using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_3c52-6398b8e5")]
        public void Method_1016_3c52()
        {
            ii(0x1016_3c52, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1016_3c57, 5);  call(Definitions.sys_check_available_stack_size, 0x20f6);/* call 0x10165d52 */
            ii(0x1016_3c5c, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_3c5d, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_3c5e, 1);  push(esi);                            /* push esi */
            ii(0x1016_3c5f, 1);  push(edi);                            /* push edi */
            ii(0x1016_3c60, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_3c61, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1016_3c63, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1016_3c69, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_3c6c, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1016_3c6f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3c72, 4);  mov(dx, memw[ds, eax + 8]);           /* mov dx, [eax+0x8] */
            ii(0x1016_3c76, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3c79, 4);  cmp(dx, memw[ds, eax + 8]);           /* cmp dx, [eax+0x8] */
            ii(0x1016_3c7d, 2);  if(jnz(0x1016_3c8f, 0x10)) goto l_0x1016_3c8f;/* jnz 0x10163c8f */
            ii(0x1016_3c7f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3c82, 4);  mov(dx, memw[ds, eax + 10]);          /* mov dx, [eax+0xa] */
            ii(0x1016_3c86, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3c89, 4);  cmp(dx, memw[ds, eax + 10]);          /* cmp dx, [eax+0xa] */
            ii(0x1016_3c8d, 2);  if(jz(0x1016_3c91, 2)) goto l_0x1016_3c91;/* jz 0x10163c91 */
        l_0x1016_3c8f:
            ii(0x1016_3c8f, 2);  jmp(0x1016_3ca1, 0x10); goto l_0x1016_3ca1;/* jmp 0x10163ca1 */
        l_0x1016_3c91:
            ii(0x1016_3c91, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3c94, 4);  mov(dx, memw[ds, eax + 12]);          /* mov dx, [eax+0xc] */
            ii(0x1016_3c98, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3c9b, 4);  cmp(dx, memw[ds, eax + 12]);          /* cmp dx, [eax+0xc] */
            ii(0x1016_3c9f, 2);  if(jz(0x1016_3ca3, 2)) goto l_0x1016_3ca3;/* jz 0x10163ca3 */
        l_0x1016_3ca1:
            ii(0x1016_3ca1, 2);  jmp(0x1016_3cb3, 0x10); goto l_0x1016_3cb3;/* jmp 0x10163cb3 */
        l_0x1016_3ca3:
            ii(0x1016_3ca3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3ca6, 4);  mov(dx, memw[ds, eax + 14]);          /* mov dx, [eax+0xe] */
            ii(0x1016_3caa, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3cad, 4);  cmp(dx, memw[ds, eax + 14]);          /* cmp dx, [eax+0xe] */
            ii(0x1016_3cb1, 2);  if(jz(0x1016_3cb5, 2)) goto l_0x1016_3cb5;/* jz 0x10163cb5 */
        l_0x1016_3cb3:
            ii(0x1016_3cb3, 2);  jmp(0x1016_3cc5, 0x10); goto l_0x1016_3cc5;/* jmp 0x10163cc5 */
        l_0x1016_3cb5:
            ii(0x1016_3cb5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3cb8, 4);  mov(dx, memw[ds, eax + 16]);          /* mov dx, [eax+0x10] */
            ii(0x1016_3cbc, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3cbf, 4);  cmp(dx, memw[ds, eax + 16]);          /* cmp dx, [eax+0x10] */
            ii(0x1016_3cc3, 2);  if(jz(0x1016_3cc7, 2)) goto l_0x1016_3cc7;/* jz 0x10163cc7 */
        l_0x1016_3cc5:
            ii(0x1016_3cc5, 2);  jmp(0x1016_3cd7, 0x10); goto l_0x1016_3cd7;/* jmp 0x10163cd7 */
        l_0x1016_3cc7:
            ii(0x1016_3cc7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3cca, 4);  mov(dx, memw[ds, eax + 18]);          /* mov dx, [eax+0x12] */
            ii(0x1016_3cce, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3cd1, 4);  cmp(dx, memw[ds, eax + 18]);          /* cmp dx, [eax+0x12] */
            ii(0x1016_3cd5, 2);  if(jz(0x1016_3cd9, 2)) goto l_0x1016_3cd9;/* jz 0x10163cd9 */
        l_0x1016_3cd7:
            ii(0x1016_3cd7, 2);  jmp(0x1016_3ce9, 0x10); goto l_0x1016_3ce9;/* jmp 0x10163ce9 */
        l_0x1016_3cd9:
            ii(0x1016_3cd9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3cdc, 4);  mov(dx, memw[ds, eax + 20]);          /* mov dx, [eax+0x14] */
            ii(0x1016_3ce0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3ce3, 4);  cmp(dx, memw[ds, eax + 20]);          /* cmp dx, [eax+0x14] */
            ii(0x1016_3ce7, 2);  if(jz(0x1016_3ceb, 2)) goto l_0x1016_3ceb;/* jz 0x10163ceb */
        l_0x1016_3ce9:
            ii(0x1016_3ce9, 2);  jmp(0x1016_3cfb, 0x10); goto l_0x1016_3cfb;/* jmp 0x10163cfb */
        l_0x1016_3ceb:
            ii(0x1016_3ceb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3cee, 4);  mov(dx, memw[ds, eax + 23]);          /* mov dx, [eax+0x17] */
            ii(0x1016_3cf2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3cf5, 4);  cmp(dx, memw[ds, eax + 23]);          /* cmp dx, [eax+0x17] */
            ii(0x1016_3cf9, 2);  if(jz(0x1016_3cfd, 2)) goto l_0x1016_3cfd;/* jz 0x10163cfd */
        l_0x1016_3cfb:
            ii(0x1016_3cfb, 2);  jmp(0x1016_3d0d, 0x10); goto l_0x1016_3d0d;/* jmp 0x10163d0d */
        l_0x1016_3cfd:
            ii(0x1016_3cfd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3d00, 4);  mov(dx, memw[ds, eax + 25]);          /* mov dx, [eax+0x19] */
            ii(0x1016_3d04, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3d07, 4);  cmp(dx, memw[ds, eax + 25]);          /* cmp dx, [eax+0x19] */
            ii(0x1016_3d0b, 2);  if(jz(0x1016_3d0f, 2)) goto l_0x1016_3d0f;/* jz 0x10163d0f */
        l_0x1016_3d0d:
            ii(0x1016_3d0d, 2);  jmp(0x1016_3d1f, 0x10); goto l_0x1016_3d1f;/* jmp 0x10163d1f */
        l_0x1016_3d0f:
            ii(0x1016_3d0f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3d12, 4);  mov(dx, memw[ds, eax + 27]);          /* mov dx, [eax+0x1b] */
            ii(0x1016_3d16, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3d19, 4);  cmp(dx, memw[ds, eax + 27]);          /* cmp dx, [eax+0x1b] */
            ii(0x1016_3d1d, 2);  if(jz(0x1016_3d21, 2)) goto l_0x1016_3d21;/* jz 0x10163d21 */
        l_0x1016_3d1f:
            ii(0x1016_3d1f, 2);  jmp(0x1016_3d31, 0x10); goto l_0x1016_3d31;/* jmp 0x10163d31 */
        l_0x1016_3d21:
            ii(0x1016_3d21, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3d24, 4);  mov(dx, memw[ds, eax + 29]);          /* mov dx, [eax+0x1d] */
            ii(0x1016_3d28, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3d2b, 4);  cmp(dx, memw[ds, eax + 29]);          /* cmp dx, [eax+0x1d] */
            ii(0x1016_3d2f, 2);  if(jz(0x1016_3d33, 2)) goto l_0x1016_3d33;/* jz 0x10163d33 */
        l_0x1016_3d31:
            ii(0x1016_3d31, 2);  jmp(0x1016_3d43, 0x10); goto l_0x1016_3d43;/* jmp 0x10163d43 */
        l_0x1016_3d33:
            ii(0x1016_3d33, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3d36, 4);  mov(dx, memw[ds, eax + 33]);          /* mov dx, [eax+0x21] */
            ii(0x1016_3d3a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3d3d, 4);  cmp(dx, memw[ds, eax + 33]);          /* cmp dx, [eax+0x21] */
            ii(0x1016_3d41, 2);  if(jz(0x1016_3d45, 2)) goto l_0x1016_3d45;/* jz 0x10163d45 */
        l_0x1016_3d43:
            ii(0x1016_3d43, 2);  jmp(0x1016_3d55, 0x10); goto l_0x1016_3d55;/* jmp 0x10163d55 */
        l_0x1016_3d45:
            ii(0x1016_3d45, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3d48, 4);  mov(dx, memw[ds, eax + 31]);          /* mov dx, [eax+0x1f] */
            ii(0x1016_3d4c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3d4f, 4);  cmp(dx, memw[ds, eax + 31]);          /* cmp dx, [eax+0x1f] */
            ii(0x1016_3d53, 2);  if(jz(0x1016_3d57, 2)) goto l_0x1016_3d57;/* jz 0x10163d57 */
        l_0x1016_3d55:
            ii(0x1016_3d55, 2);  jmp(0x1016_3d65, 0xe); goto l_0x1016_3d65;/* jmp 0x10163d65 */
        l_0x1016_3d57:
            ii(0x1016_3d57, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3d5a, 3);  mov(dl, memb[ds, eax + 35]);          /* mov dl, [eax+0x23] */
            ii(0x1016_3d5d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3d60, 3);  cmp(dl, memb[ds, eax + 35]);          /* cmp dl, [eax+0x23] */
            ii(0x1016_3d63, 2);  if(jz(0x1016_3d67, 2)) goto l_0x1016_3d67;/* jz 0x10163d67 */
        l_0x1016_3d65:
            ii(0x1016_3d65, 2);  jmp(0x1016_3d75, 0xe); goto l_0x1016_3d75;/* jmp 0x10163d75 */
        l_0x1016_3d67:
            ii(0x1016_3d67, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3d6a, 3);  mov(dl, memb[ds, eax + 22]);          /* mov dl, [eax+0x16] */
            ii(0x1016_3d6d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3d70, 3);  cmp(dl, memb[ds, eax + 22]);          /* cmp dl, [eax+0x16] */
            ii(0x1016_3d73, 2);  if(jz(0x1016_3d77, 2)) goto l_0x1016_3d77;/* jz 0x10163d77 */
        l_0x1016_3d75:
            ii(0x1016_3d75, 2);  jmp(0x1016_3d7d, 6); goto l_0x1016_3d7d;/* jmp 0x10163d7d */
        l_0x1016_3d77:
            ii(0x1016_3d77, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1016_3d7b, 2);  jmp(0x1016_3d81, 4); goto l_0x1016_3d81;/* jmp 0x10163d81 */
        l_0x1016_3d7d:
            ii(0x1016_3d7d, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x1016_3d81:
            ii(0x1016_3d81, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1016_3d84, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
            ii(0x1016_3d87, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1016_3d8a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1016_3d8c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_3d8d, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_3d8e, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_3d8f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_3d90, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_3d91, 1);  ret();                                /* ret */
        }
    }
}

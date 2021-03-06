using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_fac2-e2f4616a")]
        public void /* sys */ Method_1017_fac2()
        {
            ii(0x1017_fac2, 1);  push(ecx);                            /* push ecx */
            ii(0x1017_fac3, 1);  push(esi);                            /* push esi */
            ii(0x1017_fac4, 1);  push(edi);                            /* push edi */
            ii(0x1017_fac5, 1);  push(ebp);                            /* push ebp */
            ii(0x1017_fac6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1017_fac8, 6);  sub(esp, 0x30);                       /* sub esp, 0x30 */
            ii(0x1017_face, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1017_fad1, 3);  mov(memd[ss, ebp - 24], edx);         /* mov [ebp-0x18], edx */
            ii(0x1017_fad4, 3);  mov(memd[ss, ebp - 32], ebx);         /* mov [ebp-0x20], ebx */
            ii(0x1017_fad7, 5);  call(/* sys */ 0x1019_52c7, 0x1_57eb);/* call 0x101952c7 */
            ii(0x1017_fadc, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1017_fae1, 3);  cmp(eax, 3);                          /* cmp eax, 0x3 */
            ii(0x1017_fae4, 2);  if(jnz(0x1017_fb29, 0x43)) goto l_0x1017_fb29;/* jnz 0x1017fb29 */
            ii(0x1017_fae6, 3);  lea(ebx, memd[ss, ebp - 20]);         /* lea ebx, [ebp-0x14] */
            ii(0x1017_fae9, 3);  lea(edx, memd[ss, ebp - 16]);         /* lea edx, [ebp-0x10] */
            ii(0x1017_faec, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1017_faef, 5);  call(/* sys */ 0x1017_fb9b, 0xa7);    /* call 0x1017fb9b */
            ii(0x1017_faf4, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_faf6, 2);  if(jz(0x1017_fb0a, 0x12)) goto l_0x1017_fb0a;/* jz 0x1017fb0a */
            ii(0x1017_faf8, 6);  mov(memw[ss, ebp - 44], 0);           /* mov word [ebp-0x2c], 0x0 */
            ii(0x1017_fafe, 7);  mov(memd[ss, ebp - 48], 0);           /* mov dword [ebp-0x30], 0x0 */
            ii(0x1017_fb05, 5);  jmp(0x1017_fb90, 0x86); goto l_0x1017_fb90;/* jmp 0x1017fb90 */
        l_0x1017_fb0a:
            ii(0x1017_fb0a, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1017_fb0d, 3);  mov(edx, memd[ss, ebp - 24]);         /* mov edx, [ebp-0x18] */
            ii(0x1017_fb10, 2);  mov(memd[ds, edx], eax);              /* mov [edx], eax */
            ii(0x1017_fb12, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1017_fb15, 3);  mov(edx, memd[ss, ebp - 32]);         /* mov edx, [ebp-0x20] */
            ii(0x1017_fb18, 2);  mov(memd[ds, edx], eax);              /* mov [edx], eax */
            ii(0x1017_fb1a, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1017_fb1d, 4);  mov(memw[ss, ebp - 44], ax);          /* mov [ebp-0x2c], ax */
            ii(0x1017_fb21, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1017_fb24, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x1017_fb27, 2);  jmp(0x1017_fb90, 0x67); goto l_0x1017_fb90;/* jmp 0x1017fb90 */
        l_0x1017_fb29:
            ii(0x1017_fb29, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1017_fb2c, 1);  push(eax);                            /* push eax */
            ii(0x1017_fb2d, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x1017_fb30, 1);  push(eax);                            /* push eax */
            ii(0x1017_fb31, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1017_fb34, 3);  shr(eax, 4);                          /* shr eax, 0x4 */
            ii(0x1017_fb37, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x1017_fb3a, 1);  push(eax);                            /* push eax */
            ii(0x1017_fb3b, 5);  call(/* sys */ 0x1019_4e07, 0x1_52c7);/* call 0x10194e07 */
            ii(0x1017_fb40, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x1017_fb43, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1017_fb46, 3);  mov(edx, memd[ss, ebp - 24]);         /* mov edx, [ebp-0x18] */
            ii(0x1017_fb49, 2);  mov(memd[ds, edx], eax);              /* mov [edx], eax */
        l_0x1017_fb4b:
            ii(0x1017_fb4b, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1017_fb4e, 6);  and(edx, 0xffff);                     /* and edx, 0xffff */
            ii(0x1017_fb54, 5);  mov(eax, 0xffff);                     /* mov eax, 0xffff */
            ii(0x1017_fb59, 3);  sub(eax, memd[ss, ebp - 28]);         /* sub eax, [ebp-0x1c] */
            ii(0x1017_fb5c, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1017_fb5e, 2);  if(jbe(0x1017_fb84, 0x24)) goto l_0x1017_fb84;/* jbe 0x1017fb84 */
            ii(0x1017_fb60, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1017_fb63, 1);  push(eax);                            /* push eax */
            ii(0x1017_fb64, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x1017_fb67, 1);  push(eax);                            /* push eax */
            ii(0x1017_fb68, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1017_fb6b, 3);  shr(eax, 4);                          /* shr eax, 0x4 */
            ii(0x1017_fb6e, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x1017_fb71, 1);  push(eax);                            /* push eax */
            ii(0x1017_fb72, 5);  call(/* sys */ 0x1019_4e07, 0x1_5290);/* call 0x10194e07 */
            ii(0x1017_fb77, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x1017_fb7a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1017_fb7d, 3);  mov(edx, memd[ss, ebp - 24]);         /* mov edx, [ebp-0x18] */
            ii(0x1017_fb80, 2);  mov(memd[ds, edx], eax);              /* mov [edx], eax */
            ii(0x1017_fb82, 2);  jmp(0x1017_fb4b, -0x39); goto l_0x1017_fb4b;/* jmp 0x1017fb4b */
        l_0x1017_fb84:
            ii(0x1017_fb84, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1017_fb86, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1017_fb89, 4);  mov(memw[ss, ebp - 44], ax);          /* mov [ebp-0x2c], ax */
            ii(0x1017_fb8d, 3);  mov(memd[ss, ebp - 48], edx);         /* mov [ebp-0x30], edx */
        l_0x1017_fb90:
            ii(0x1017_fb90, 3);  mov(edx, memd[ss, ebp - 44]);         /* mov edx, [ebp-0x2c] */
            ii(0x1017_fb93, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1017_fb96, 1);  leave();                              /* leave */
            ii(0x1017_fb97, 1);  pop(edi);                             /* pop edi */
            ii(0x1017_fb98, 1);  pop(esi);                             /* pop esi */
            ii(0x1017_fb99, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1017_fb9a, 1);  ret();                                /* ret */
        }
    }
}

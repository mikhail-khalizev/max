using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_73c8-6e01a185")]
        public void /* sys */ Method_1016_73c8()
        {
            ii(0x1016_73c8, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_73c9, 1);  push(esi);                            /* push esi */
            ii(0x1016_73ca, 1);  push(edi);                            /* push edi */
            ii(0x1016_73cb, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_73cc, 3);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1016_73cf, 5);  call(/* sys */ 0x1016_7dac, 0x9d8);   /* call 0x10167dac */
            ii(0x1016_73d4, 6);  mov(ecx, memd[ds, 0x101b_ddbc]);      /* mov ecx, [0x101bddbc] */
            ii(0x1016_73da, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1016_73dc, 2);  test(ecx, ecx);                       /* test ecx, ecx */
            ii(0x1016_73de, 6);  if(jz(0x1016_747b, 0x97)) goto l_0x1016_747b;/* jz 0x1016747b */
            ii(0x1016_73e4, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_73e6, 6);  if(jz(0x1016_747b, 0x8f)) goto l_0x1016_747b;/* jz 0x1016747b */
            ii(0x1016_73ec, 2);  mov(edi, esp);                        /* mov edi, esp */
            ii(0x1016_73ee, 3);  lea(esi, memd[ds, esi + 8]);          /* lea esi, [esi+0x8] */
            ii(0x1016_73f1, 1);  movsd();                              /* movsd */
            ii(0x1016_73f2, 1);  movsd();                              /* movsd */
            ii(0x1016_73f3, 1);  movsd();                              /* movsd */
            ii(0x1016_73f4, 1);  movsd();                              /* movsd */
            ii(0x1016_73f5, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1016_73f7, 2);  if(jge(0x1016_73fb, 2)) goto l_0x1016_73fb;/* jge 0x101673fb */
            ii(0x1016_73f9, 2);  xor(edx, edx);                        /* xor edx, edx */
        l_0x1016_73fb:
            ii(0x1016_73fb, 2);  test(ebx, ebx);                       /* test ebx, ebx */
            ii(0x1016_73fd, 2);  if(jge(0x1016_7401, 2)) goto l_0x1016_7401;/* jge 0x10167401 */
            ii(0x1016_73ff, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
        l_0x1016_7401:
            ii(0x1016_7401, 4);  test(memb[ds, eax + 5], 1);           /* test byte [eax+0x5], 0x1 */
            ii(0x1016_7405, 2);  if(jz(0x1016_740a, 3)) goto l_0x1016_740a;/* jz 0x1016740a */
            ii(0x1016_7407, 3);  add(edx, 2);                          /* add edx, 0x2 */
        l_0x1016_740a:
            ii(0x1016_740a, 3);  mov(esi, memd[ds, eax + 24]);         /* mov esi, [eax+0x18] */
            ii(0x1016_740d, 2);  add(esi, edx);                        /* add esi, edx */
            ii(0x1016_740f, 6);  mov(edi, memd[ds, 0x1020_88e8]);      /* mov edi, [0x102088e8] */
            ii(0x1016_7415, 1);  dec(esi);                             /* dec esi */
            ii(0x1016_7416, 2);  cmp(esi, edi);                        /* cmp esi, edi */
            ii(0x1016_7418, 2);  if(jle(0x1016_7420, 6)) goto l_0x1016_7420;/* jle 0x10167420 */
            ii(0x1016_741a, 2);  mov(edx, edi);                        /* mov edx, edi */
            ii(0x1016_741c, 3);  sub(edx, memd[ds, eax + 24]);         /* sub edx, [eax+0x18] */
            ii(0x1016_741f, 1);  inc(edx);                             /* inc edx */
        l_0x1016_7420:
            ii(0x1016_7420, 3);  mov(esi, memd[ds, eax + 28]);         /* mov esi, [eax+0x1c] */
            ii(0x1016_7423, 2);  add(esi, ebx);                        /* add esi, ebx */
            ii(0x1016_7425, 6);  mov(ecx, memd[ds, 0x1020_88ec]);      /* mov ecx, [0x102088ec] */
            ii(0x1016_742b, 1);  dec(esi);                             /* dec esi */
            ii(0x1016_742c, 2);  cmp(esi, ecx);                        /* cmp esi, ecx */
            ii(0x1016_742e, 2);  if(jle(0x1016_7436, 6)) goto l_0x1016_7436;/* jle 0x10167436 */
            ii(0x1016_7430, 2);  mov(ebx, ecx);                        /* mov ebx, ecx */
            ii(0x1016_7432, 3);  sub(ebx, memd[ds, eax + 28]);         /* sub ebx, [eax+0x1c] */
            ii(0x1016_7435, 1);  inc(ebx);                             /* inc ebx */
        l_0x1016_7436:
            ii(0x1016_7436, 4);  test(memb[ds, eax + 5], 1);           /* test byte [eax+0x5], 0x1 */
            ii(0x1016_743a, 2);  if(jz(0x1016_743f, 3)) goto l_0x1016_743f;/* jz 0x1016743f */
            ii(0x1016_743c, 3);  and(dl, 0xfc);                        /* and dl, 0xfc */
        l_0x1016_743f:
            ii(0x1016_743f, 3);  mov(edi, memd[ds, eax + 24]);         /* mov edi, [eax+0x18] */
            ii(0x1016_7442, 3);  mov(ebp, memd[ds, eax + 28]);         /* mov ebp, [eax+0x1c] */
            ii(0x1016_7445, 3);  mov(memd[ds, eax + 8], edx);          /* mov [eax+0x8], edx */
            ii(0x1016_7448, 2);  add(edx, edi);                        /* add edx, edi */
            ii(0x1016_744a, 3);  mov(memd[ds, eax + 12], ebx);         /* mov [eax+0xc], ebx */
            ii(0x1016_744d, 1);  dec(edx);                             /* dec edx */
            ii(0x1016_744e, 2);  add(ebx, ebp);                        /* add ebx, ebp */
            ii(0x1016_7450, 3);  mov(memd[ds, eax + 16], edx);         /* mov [eax+0x10], edx */
            ii(0x1016_7453, 1);  dec(ebx);                             /* dec ebx */
            ii(0x1016_7454, 3);  mov(dl, memb[ds, eax + 4]);           /* mov dl, [eax+0x4] */
            ii(0x1016_7457, 3);  mov(memd[ds, eax + 20], ebx);         /* mov [eax+0x14], ebx */
            ii(0x1016_745a, 3);  test(dl, 8);                          /* test dl, 0x8 */
            ii(0x1016_745d, 2);  if(jnz(0x1016_747b, 0x1c)) goto l_0x1016_747b;/* jnz 0x1016747b */
            ii(0x1016_745f, 3);  lea(edx, memd[ds, eax + 8]);          /* lea edx, [eax+0x8] */
            ii(0x1016_7462, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1016_7464, 5);  call(/* sys */ 0x1016_7500, 0x97);    /* call 0x10167500 */
            ii(0x1016_7469, 7);  cmp(memd[ds, 0x101b_ddbc], 0);        /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_7470, 2);  if(jz(0x1016_747b, 9)) goto l_0x1016_747b;/* jz 0x1016747b */
            ii(0x1016_7472, 2);  mov(eax, esp);                        /* mov eax, esp */
            ii(0x1016_7474, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_7476, 5);  call(/* sys */ 0x1016_7d38, 0x8bd);   /* call 0x10167d38 */
        l_0x1016_747b:
            ii(0x1016_747b, 3);  add(esp, 0x10);                       /* add esp, 0x10 */
            ii(0x1016_747e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_747f, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_7480, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_7481, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_7482, 1);  ret();                                /* ret */
        }
    }
}

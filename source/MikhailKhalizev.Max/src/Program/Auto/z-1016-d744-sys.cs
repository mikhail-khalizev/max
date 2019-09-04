using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_d744-7de94b01")]
        public void /* sys */ Method_1016_d744()
        {
            ii(0x1016_d744, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_d745, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_d746, 1);  push(esi);                            /* push esi */
            ii(0x1016_d747, 1);  push(edi);                            /* push edi */
            ii(0x1016_d748, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_d749, 3);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1016_d74c, 6);  mov(ebp, memd[ds, 0x1020_8524]);      /* mov ebp, [0x10208524] */
            ii(0x1016_d752, 4);  mov(memd[ss, esp + 8], eax);          /* mov [esp+0x8], eax */
            ii(0x1016_d756, 4);  mov(memd[ss, esp + 16], edx);         /* mov [esp+0x10], edx */
            ii(0x1016_d75a, 5);  mov(edx, 0x20);                       /* mov edx, 0x20 */
            ii(0x1016_d75f, 5);  mov(ecx, 8);                          /* mov ecx, 0x8 */
            ii(0x1016_d764, 5);  mov(ebx, 0x40);                       /* mov ebx, 0x40 */
            ii(0x1016_d769, 5);  mov(edi, 0x400);                      /* mov edi, 0x400 */
            ii(0x1016_d76e, 5);  mov(eax, 0x2_0000);                   /* mov eax, 0x20000 */
            ii(0x1016_d773, 6);  mov(memd[ds, 0x1020_8530], edx);      /* mov [0x10208530], edx */
            ii(0x1016_d779, 6);  mov(memd[ds, 0x1020_8534], ebx);      /* mov [0x10208534], ebx */
            ii(0x1016_d77f, 6);  mov(memd[ds, 0x1020_853c], edx);      /* mov [0x1020853c], edx */
            ii(0x1016_d785, 6);  mov(memd[ds, 0x1020_8540], edi);      /* mov [0x10208540], edi */
            ii(0x1016_d78b, 6);  mov(memd[ds, 0x1020_852c], ecx);      /* mov [0x1020852c], ecx */
            ii(0x1016_d791, 5);  call(Definitions.sys_malloc, -0x27b8);/* call 0x1016afde */
            ii(0x1016_d796, 6);  mov(ecx, memd[ds, 0x1020_852c]);      /* mov ecx, [0x1020852c] */
            ii(0x1016_d79c, 4);  mov(memd[ss, esp + 12], eax);         /* mov [esp+0xc], eax */
            ii(0x1016_d7a0, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_d7a2, 2);  if(jnz(0x1016_d7ae, 0xa)) goto l_0x1016_d7ae;/* jnz 0x1016d7ae */
            ii(0x1016_d7a4, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1016_d7a9, 5);  jmp(0x1016_da55, 0x2a7); goto l_0x1016_da55;/* jmp 0x1016da55 */
        l_0x1016_d7ae:
            ii(0x1016_d7ae, 6);  mov(edx, memd[ds, 0x1020_8530]);      /* mov edx, [0x10208530] */
            ii(0x1016_d7b4, 2);  mov(ebx, edx);                        /* mov ebx, edx */
            ii(0x1016_d7b6, 3);  imul(ebx, edx);                       /* imul ebx, edx */
            ii(0x1016_d7b9, 3);  imul(edx, ebx);                       /* imul edx, ebx */
            ii(0x1016_d7bc, 6);  mov(ebp, memd[ds, 0x1020_8524]);      /* mov ebp, [0x10208524] */
            ii(0x1016_d7c2, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1016_d7c4, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1016_d7c6, 2);  if(jle(0x1016_d7d6, 0xe)) goto l_0x1016_d7d6;/* jle 0x1016d7d6 */
        l_0x1016_d7c8:
            ii(0x1016_d7c8, 1);  dec(edx);                             /* dec edx */
            ii(0x1016_d7c9, 6);  mov(memd[ds, ebx], 0xffff_ffff);      /* mov dword [ebx], 0xffffffff */
            ii(0x1016_d7cf, 3);  add(ebx, 4);                          /* add ebx, 0x4 */
            ii(0x1016_d7d2, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1016_d7d4, 2);  if(jg(0x1016_d7c8, -0xe)) goto l_0x1016_d7c8;/* jg 0x1016d7c8 */
        l_0x1016_d7d6:
            ii(0x1016_d7d6, 5);  mov(ebx, 0x8000);                     /* mov ebx, 0x8000 */
            ii(0x1016_d7db, 5);  mov(eax, 0x1020_0520);                /* mov eax, 0x10200520 */
            ii(0x1016_d7e0, 6);  mov(memd[ds, 0x1020_8524], ebp);      /* mov [0x10208524], ebp */
            ii(0x1016_d7e6, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_d7e8, 2);  xor(ebp, ebp);                        /* xor ebp, ebp */
            ii(0x1016_d7ea, 5);  call(Definitions.sys_memset, -0x7a0f);/* call 0x10165de0 */
            ii(0x1016_d7ef, 6);  mov(memd[ds, 0x1020_8524], ebp);      /* mov [0x10208524], ebp */
        l_0x1016_d7f5:
            ii(0x1016_d7f5, 4);  mov(eax, memd[ss, esp + 16]);         /* mov eax, [esp+0x10] */
            ii(0x1016_d7f9, 6);  mov(ebp, memd[ds, 0x1020_8524]);      /* mov ebp, [0x10208524] */
            ii(0x1016_d7ff, 6);  mov(ecx, memd[ds, 0x1020_852c]);      /* mov ecx, [0x1020852c] */
            ii(0x1016_d805, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_d807, 2);  if(jz(0x1016_d81e, 0x15)) goto l_0x1016_d81e;/* jz 0x1016d81e */
            ii(0x1016_d809, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1016_d80b, 4);  cmp(memb[ds, edx + ebp], 0);          /* cmp byte [edx+ebp], 0x0 */
            ii(0x1016_d80f, 2);  if(jz(0x1016_d81e, 0xd)) goto l_0x1016_d81e;/* jz 0x1016d81e */
            ii(0x1016_d811, 2);  xor(bh, bh);                          /* xor bh, bh */
            ii(0x1016_d813, 6);  mov(memb[ss, ebp + 0x101d_0420], bh); /* mov [ebp+0x101d0420], bh */
            ii(0x1016_d819, 5);  jmp(0x1016_da15, 0x1f7); goto l_0x1016_da15;/* jmp 0x1016da15 */
        l_0x1016_d81e:
            ii(0x1016_d81e, 4);  mov(ebx, memd[ss, esp + 8]);          /* mov ebx, [esp+0x8] */
            ii(0x1016_d822, 4);  lea(edx, memd[ss, ebp + ebp * 2]);    /* lea edx, [ebp+ebp*2] */
            ii(0x1016_d826, 2);  add(edx, ebx);                        /* add edx, ebx */
            ii(0x1016_d828, 2);  mov(bl, memb[ds, edx]);               /* mov bl, [edx] */
            ii(0x1016_d82a, 3);  mov(al, memb[ds, edx + 1]);           /* mov al, [edx+0x1] */
            ii(0x1016_d82d, 3);  movzx(esi, bl);                       /* movzx esi, bl */
            ii(0x1016_d830, 3);  mov(ah, memb[ds, edx + 2]);           /* mov ah, [edx+0x2] */
            ii(0x1016_d833, 2);  mov(edx, esi);                        /* mov edx, esi */
            ii(0x1016_d835, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1016_d837, 3);  movzx(edi, ah);                       /* movzx edi, ah */
            ii(0x1016_d83a, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1016_d83c, 2);  mov(eax, edi);                        /* mov eax, edi */
            ii(0x1016_d83e, 3);  sar(edx, 3);                          /* sar edx, 0x3 */
            ii(0x1016_d841, 3);  sar(eax, 3);                          /* sar eax, 0x3 */
            ii(0x1016_d844, 6);  mov(memd[ds, 0x1020_8568], edx);      /* mov [0x10208568], edx */
            ii(0x1016_d84a, 5);  mov(memd[ds, 0x1020_855c], eax);      /* mov [0x1020855c], eax */
            ii(0x1016_d84f, 5);  mov(eax, memd[ds, 0x1020_8568]);      /* mov eax, [0x10208568] */
            ii(0x1016_d854, 3);  imul(eax, ecx);                       /* imul eax, ecx */
            ii(0x1016_d857, 2);  mov(edx, ebx);                        /* mov edx, ebx */
            ii(0x1016_d859, 3);  sar(edx, 3);                          /* sar edx, 0x3 */
            ii(0x1016_d85c, 6);  mov(memd[ds, 0x1020_8558], edx);      /* mov [0x10208558], edx */
            ii(0x1016_d862, 2);  mov(edx, ecx);                        /* mov edx, ecx */
            ii(0x1016_d864, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1016_d867, 3);  mov(memd[ss, esp], eax);              /* mov [esp], eax */
            ii(0x1016_d86a, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1016_d86c, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1016_d86e, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1016_d870, 3);  mov(edx, memd[ss, esp]);              /* mov edx, [esp] */
            ii(0x1016_d873, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1016_d875, 3);  mov(memd[ss, esp], edx);              /* mov [esp], edx */
            ii(0x1016_d878, 2);  mov(edx, esi);                        /* mov edx, esi */
            ii(0x1016_d87a, 3);  sub(edx, memd[ss, esp]);              /* sub edx, [esp] */
            ii(0x1016_d87d, 6);  mov(memd[ds, 0x1020_856c], edx);      /* mov [0x1020856c], edx */
            ii(0x1016_d883, 6);  mov(edx, memd[ds, 0x1020_8558]);      /* mov edx, [0x10208558] */
            ii(0x1016_d889, 3);  imul(edx, ecx);                       /* imul edx, ecx */
            ii(0x1016_d88c, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1016_d88e, 3);  mov(memd[ss, esp], edx);              /* mov [esp], edx */
            ii(0x1016_d891, 2);  mov(edx, ebx);                        /* mov edx, ebx */
            ii(0x1016_d893, 3);  sub(edx, memd[ss, esp]);              /* sub edx, [esp] */
            ii(0x1016_d896, 6);  mov(memd[ds, 0x1020_8574], edx);      /* mov [0x10208574], edx */
            ii(0x1016_d89c, 6);  mov(edx, memd[ds, 0x1020_855c]);      /* mov edx, [0x1020855c] */
            ii(0x1016_d8a2, 3);  imul(edx, ecx);                       /* imul edx, ecx */
            ii(0x1016_d8a5, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1016_d8a7, 2);  mov(edx, edi);                        /* mov edx, edi */
            ii(0x1016_d8a9, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x1016_d8ab, 5);  mov(eax, memd[ds, 0x1020_856c]);      /* mov eax, [0x1020856c] */
            ii(0x1016_d8b0, 3);  imul(eax, eax);                       /* imul eax, eax */
            ii(0x1016_d8b3, 8);  mov(memd[ss, esp + 20], 9);           /* mov dword [esp+0x14], 0x9 */
            ii(0x1016_d8bb, 6);  mov(memd[ds, 0x1020_8564], edx);      /* mov [0x10208564], edx */
            ii(0x1016_d8c1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_d8c3, 4);  div(memd[ss, esp + 20]);              /* div dword [esp+0x14] */
            ii(0x1016_d8c7, 3);  mov(memd[ss, esp], eax);              /* mov [esp], eax */
            ii(0x1016_d8ca, 5);  mov(eax, memd[ds, 0x1020_8574]);      /* mov eax, [0x10208574] */
            ii(0x1016_d8cf, 3);  imul(eax, eax);                       /* imul eax, eax */
            ii(0x1016_d8d2, 8);  mov(memd[ss, esp + 20], 0x24);        /* mov dword [esp+0x14], 0x24 */
            ii(0x1016_d8da, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_d8dc, 4);  div(memd[ss, esp + 20]);              /* div dword [esp+0x14] */
            ii(0x1016_d8e0, 3);  mov(edx, memd[ss, esp]);              /* mov edx, [esp] */
            ii(0x1016_d8e3, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1016_d8e5, 3);  mov(memd[ss, esp], edx);              /* mov [esp], edx */
            ii(0x1016_d8e8, 6);  mov(edx, memd[ds, 0x1020_8564]);      /* mov edx, [0x10208564] */
            ii(0x1016_d8ee, 3);  imul(edx, edx);                       /* imul edx, edx */
            ii(0x1016_d8f1, 3);  mov(eax, memd[ss, esp]);              /* mov eax, [esp] */
            ii(0x1016_d8f4, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1016_d8f6, 6);  mov(edx, memd[ds, 0x1020_8568]);      /* mov edx, [0x10208568] */
            ii(0x1016_d8fc, 5);  mov(memd[ds, 0x1020_8564], eax);      /* mov [0x10208564], eax */
            ii(0x1016_d901, 5);  mov(eax, memd[ds, 0x1020_8534]);      /* mov eax, [0x10208534] */
            ii(0x1016_d906, 1);  inc(edx);                             /* inc edx */
            ii(0x1016_d907, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x1016_d90a, 2);  mov(edx, esi);                        /* mov edx, esi */
            ii(0x1016_d90c, 3);  imul(edx, ecx);                       /* imul edx, ecx */
            ii(0x1016_d90f, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1016_d911, 3);  lea(edx, memd[ds, eax + eax]);        /* lea edx, [eax+eax] */
            ii(0x1016_d914, 6);  mov(memd[ds, 0x1020_8544], edx);      /* mov [0x10208544], edx */
            ii(0x1016_d91a, 6);  mov(edx, memd[ds, 0x1020_8558]);      /* mov edx, [0x10208558] */
            ii(0x1016_d920, 5);  mov(eax, memd[ds, 0x1020_8534]);      /* mov eax, [0x10208534] */
            ii(0x1016_d925, 1);  inc(edx);                             /* inc edx */
            ii(0x1016_d926, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x1016_d929, 2);  mov(edx, ebx);                        /* mov edx, ebx */
            ii(0x1016_d92b, 3);  imul(edx, ecx);                       /* imul edx, ecx */
            ii(0x1016_d92e, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1016_d930, 3);  lea(edx, memd[ds, eax + eax]);        /* lea edx, [eax+eax] */
            ii(0x1016_d933, 6);  mov(memd[ds, 0x1020_854c], edx);      /* mov [0x1020854c], edx */
            ii(0x1016_d939, 6);  mov(edx, memd[ds, 0x1020_855c]);      /* mov edx, [0x1020855c] */
            ii(0x1016_d93f, 5);  mov(eax, memd[ds, 0x1020_8534]);      /* mov eax, [0x10208534] */
            ii(0x1016_d944, 1);  inc(edx);                             /* inc edx */
            ii(0x1016_d945, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x1016_d948, 2);  mov(edx, edi);                        /* mov edx, edi */
            ii(0x1016_d94a, 3);  imul(edx, ecx);                       /* imul edx, ecx */
            ii(0x1016_d94d, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1016_d94f, 3);  lea(edx, memd[ds, eax + eax]);        /* lea edx, [eax+eax] */
            ii(0x1016_d952, 5);  mov(eax, memd[ds, 0x1020_8568]);      /* mov eax, [0x10208568] */
            ii(0x1016_d957, 6);  mov(memd[ds, 0x1020_8548], edx);      /* mov [0x10208548], edx */
            ii(0x1016_d95d, 6);  mov(edx, memd[ds, 0x1020_8540]);      /* mov edx, [0x10208540] */
            ii(0x1016_d963, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x1016_d966, 3);  mov(memd[ss, esp], eax);              /* mov [esp], eax */
            ii(0x1016_d969, 7);  lea(edx, memd[ds, eax * 4]);          /* lea edx, [eax*4] */
            ii(0x1016_d970, 4);  mov(eax, memd[ss, esp + 12]);         /* mov eax, [esp+0xc] */
            ii(0x1016_d974, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1016_d976, 6);  mov(edx, memd[ds, 0x1020_8558]);      /* mov edx, [0x10208558] */
            ii(0x1016_d97c, 4);  mov(memd[ss, esp + 20], eax);         /* mov [esp+0x14], eax */
            ii(0x1016_d980, 7);  imul(edx, memd[ds, 0x1020_853c]);     /* imul edx, [0x1020853c] */
            ii(0x1016_d987, 7);  lea(eax, memd[ds, edx * 4]);          /* lea eax, [edx*4] */
            ii(0x1016_d98e, 4);  mov(memd[ss, esp + 4], eax);          /* mov [esp+0x4], eax */
            ii(0x1016_d992, 4);  mov(eax, memd[ss, esp + 20]);         /* mov eax, [esp+0x14] */
            ii(0x1016_d996, 4);  add(eax, memd[ss, esp + 4]);          /* add eax, [esp+0x4] */
            ii(0x1016_d99a, 4);  mov(memd[ss, esp + 4], eax);          /* mov [esp+0x4], eax */
            ii(0x1016_d99e, 5);  mov(eax, memd[ds, 0x1020_855c]);      /* mov eax, [0x1020855c] */
            ii(0x1016_d9a3, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1016_d9a6, 4);  mov(memd[ss, esp + 20], eax);         /* mov [esp+0x14], eax */
            ii(0x1016_d9aa, 4);  mov(eax, memd[ss, esp + 4]);          /* mov eax, [esp+0x4] */
            ii(0x1016_d9ae, 4);  add(eax, memd[ss, esp + 20]);         /* add eax, [esp+0x14] */
            ii(0x1016_d9b2, 5);  mov(memd[ds, 0x1020_8554], eax);      /* mov [0x10208554], eax */
            ii(0x1016_d9b7, 5);  mov(eax, 0x1020_0520);                /* mov eax, 0x10200520 */
            ii(0x1016_d9bc, 3);  add(eax, memd[ss, esp]);              /* add eax, [esp] */
            ii(0x1016_d9bf, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1016_d9c1, 5);  mov(eax, memd[ds, 0x1020_855c]);      /* mov eax, [0x1020855c] */
            ii(0x1016_d9c6, 6);  mov(memd[ds, 0x1020_852c], ecx);      /* mov [0x1020852c], ecx */
            ii(0x1016_d9cc, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1016_d9ce, 6);  mov(memd[ds, 0x1020_8524], ebp);      /* mov [0x10208524], ebp */
            ii(0x1016_d9d4, 5);  mov(memd[ds, 0x1020_8528], eax);      /* mov [0x10208528], eax */
            ii(0x1016_d9d9, 5);  call(/* sys */ 0x1016_da84, 0xa6);    /* call 0x1016da84 */
            ii(0x1016_d9de, 6);  mov(ebp, memd[ds, 0x1020_8524]);      /* mov ebp, [0x10208524] */
            ii(0x1016_d9e4, 4);  lea(edx, memd[ss, ebp + ebp * 2]);    /* lea edx, [ebp+ebp*2] */
            ii(0x1016_d9e8, 3);  sar(ebx, 2);                          /* sar ebx, 0x2 */
            ii(0x1016_d9eb, 6);  mov(ecx, memd[ds, 0x1020_852c]);      /* mov ecx, [0x1020852c] */
            ii(0x1016_d9f1, 6);  mov(memb[ds, edx + 0x101b_dec1], bl); /* mov [edx+0x101bdec1], bl */
            ii(0x1016_d9f7, 2);  mov(ebx, edi);                        /* mov ebx, edi */
            ii(0x1016_d9f9, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1016_d9fb, 3);  sar(ebx, 2);                          /* sar ebx, 0x2 */
            ii(0x1016_d9fe, 3);  sar(eax, 2);                          /* sar eax, 0x2 */
            ii(0x1016_da01, 6);  mov(memb[ds, edx + 0x101b_dec2], bl); /* mov [edx+0x101bdec2], bl */
            ii(0x1016_da07, 2);  mov(bl, 1);                           /* mov bl, 0x1 */
            ii(0x1016_da09, 6);  mov(memb[ds, edx + 0x101b_dec0], al); /* mov [edx+0x101bdec0], al */
            ii(0x1016_da0f, 6);  mov(memb[ss, ebp + 0x101d_0420], bl); /* mov [ebp+0x101d0420], bl */
        l_0x1016_da15:
            ii(0x1016_da15, 1);  inc(ebp);                             /* inc ebp */
            ii(0x1016_da16, 6);  mov(memd[ds, 0x1020_852c], ecx);      /* mov [0x1020852c], ecx */
            ii(0x1016_da1c, 6);  mov(memd[ds, 0x1020_8524], ebp);      /* mov [0x10208524], ebp */
            ii(0x1016_da22, 6);  cmp(ebp, 0x100);                      /* cmp ebp, 0x100 */
            ii(0x1016_da28, 6);  if(jl(0x1016_d7f5, -0x239)) goto l_0x1016_d7f5;/* jl 0x1016d7f5 */
            ii(0x1016_da2e, 4);  mov(eax, memd[ss, esp + 12]);         /* mov eax, [esp+0xc] */
            ii(0x1016_da32, 5);  call(Definitions.sys_free, -0x2976);  /* call 0x1016b0c1 */
            ii(0x1016_da37, 5);  call(/* sys */ 0x1016_ce8c, -0xbb0);  /* call 0x1016ce8c */
            ii(0x1016_da3c, 2);  xor(edx, edx);                        /* xor edx, edx */
        l_0x1016_da3e:
            ii(0x1016_da3e, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1016_da40, 1);  inc(edx);                             /* inc edx */
            ii(0x1016_da41, 5);  call(/* sys */ 0x1016_ced0, -0xb76);  /* call 0x1016ced0 */
            ii(0x1016_da46, 6);  cmp(edx, 0x100);                      /* cmp edx, 0x100 */
            ii(0x1016_da4c, 2);  if(jl(0x1016_da3e, -0x10)) goto l_0x1016_da3e;/* jl 0x1016da3e */
            ii(0x1016_da4e, 5);  call(/* sys */ 0x1016_d5a0, -0x4b3);  /* call 0x1016d5a0 */
            ii(0x1016_da53, 2);  xor(edx, edx);                        /* xor edx, edx */
        l_0x1016_da55:
            ii(0x1016_da55, 6);  mov(ecx, memd[ds, 0x1020_852c]);      /* mov ecx, [0x1020852c] */
            ii(0x1016_da5b, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1016_da5d, 3);  add(esp, 0x18);                       /* add esp, 0x18 */
            ii(0x1016_da60, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_da61, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_da62, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_da63, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_da64, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_da65, 1);  ret();                                /* ret */
        }
    }
}

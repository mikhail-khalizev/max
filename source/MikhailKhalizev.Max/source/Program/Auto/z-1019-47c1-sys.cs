using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_47c1-b9a0bc2f")]
        public void /* sys */ Method_1019_47c1()
        {
            ii(0x1019_47c1, 1);  push(esi);                            /* push esi */
            ii(0x1019_47c2, 1);  push(edi);                            /* push edi */
            ii(0x1019_47c3, 1);  push(ebp);                            /* push ebp */
            ii(0x1019_47c4, 3);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1019_47c7, 1);  push(eax);                            /* push eax */
            ii(0x1019_47c8, 2);  mov(edi, edx);                        /* mov edi, edx */
            ii(0x1019_47ca, 3);  lea(eax, memd[ds, ebx + 7]);          /* lea eax, [ebx+0x7] */
            ii(0x1019_47cd, 2);  and(al, 0xfc);                        /* and al, 0xfc */
            ii(0x1019_47cf, 2);  cmp(eax, ebx);                        /* cmp eax, ebx */
            ii(0x1019_47d1, 2);  if(jae(0x1019_47d8, 5)) goto l_0x1019_47d8;/* jae 0x101947d8 */
            ii(0x1019_47d3, 5);  mov(eax, 0xffff_ffff);                /* mov eax, 0xffffffff */
        l_0x1019_47d8:
            ii(0x1019_47d8, 3);  cmp(eax, 0xc);                        /* cmp eax, 0xc */
            ii(0x1019_47db, 2);  if(jae(0x1019_47e2, 5)) goto l_0x1019_47e2;/* jae 0x101947e2 */
            ii(0x1019_47dd, 5);  mov(eax, 0xc);                        /* mov eax, 0xc */
        l_0x1019_47e2:
            ii(0x1019_47e2, 3);  lea(edx, memd[ds, edi - 4]);          /* lea edx, [edi-0x4] */
            ii(0x1019_47e5, 4);  mov(memd[ss, esp + 4], edx);          /* mov [esp+0x4], edx */
            ii(0x1019_47e9, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1019_47eb, 3);  and(dl, 0xfe);                        /* and dl, 0xfe */
            ii(0x1019_47ee, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x1019_47f0, 6);  if(jbe(0x1019_48ef, 0xf9)) goto l_0x1019_48ef;/* jbe 0x101948ef */
            ii(0x1019_47f6, 4);  mov(ebx, memd[ss, esp + 4]);          /* mov ebx, [esp+0x4] */
            ii(0x1019_47fa, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1019_47fc, 2);  add(ebx, edx);                        /* add ebx, edx */
        l_0x1019_47fe:
            ii(0x1019_47fe, 2);  mov(memd[ds, ecx], eax);              /* mov [ecx], eax */
            ii(0x1019_4800, 2);  mov(ebp, memd[ds, ebx]);              /* mov ebp, [ebx] */
            ii(0x1019_4802, 3);  cmp(ebp, -1 /* 0xff */);              /* cmp ebp, 0xffffffff */
            ii(0x1019_4805, 2);  if(jnz(0x1019_4811, 0xa)) goto l_0x1019_4811;/* jnz 0x10194811 */
            ii(0x1019_4807, 5);  mov(ebp, 2);                          /* mov ebp, 0x2 */
            ii(0x1019_480c, 5);  jmp(0x1019_4947, 0x136); goto l_0x1019_4947;/* jmp 0x10194947 */
        l_0x1019_4811:
            ii(0x1019_4811, 6);  test(ebp, 1);                         /* test ebp, 0x1 */
            ii(0x1019_4817, 6);  if(jnz(0x1019_48e8, 0xcb)) goto l_0x1019_48e8;/* jnz 0x101948e8 */
            ii(0x1019_481d, 3);  mov(eax, memd[ds, ebx + 8]);          /* mov eax, [ebx+0x8] */
            ii(0x1019_4820, 4);  mov(memd[ss, esp + 8], eax);          /* mov [esp+0x8], eax */
            ii(0x1019_4824, 3);  mov(eax, memd[ds, ebx + 4]);          /* mov eax, [ebx+0x4] */
            ii(0x1019_4827, 2);  mov(edx, ds);                         /* mov edx, ds */
            ii(0x1019_4829, 4);  mov(memd[ss, esp + 12], eax);         /* mov [esp+0xc], eax */
            ii(0x1019_482d, 5);  mov(eax, 0x101b_de0c);                /* mov eax, 0x101bde0c */
            ii(0x1019_4832, 4);  cmp(dx, memw[ss, esp]);               /* cmp dx, [esp] */
            ii(0x1019_4836, 2);  if(jnz(0x1019_4852, 0x1a)) goto l_0x1019_4852;/* jnz 0x10194852 */
            ii(0x1019_4838, 6);  mov(esi, memd[ds, 0x101b_de0c]);      /* mov esi, [0x101bde0c] */
            ii(0x1019_483e, 2);  jmp(0x1019_484b, 0xb); goto l_0x1019_484b;/* jmp 0x1019484b */
        l_0x1019_4840:
            ii(0x1019_4840, 2);  cmp(esi, edi);                        /* cmp esi, edi */
            ii(0x1019_4842, 2);  if(ja(0x1019_4848, 4)) goto l_0x1019_4848;/* ja 0x10194848 */
            ii(0x1019_4844, 2);  cmp(edi, edx);                        /* cmp edi, edx */
            ii(0x1019_4846, 2);  if(jb(0x1019_4852, 0xa)) goto l_0x1019_4852;/* jb 0x10194852 */
        l_0x1019_4848:
            ii(0x1019_4848, 3);  mov(esi, memd[ds, esi + 8]);          /* mov esi, [esi+0x8] */
        l_0x1019_484b:
            ii(0x1019_484b, 3);  mov(edx, memd[ds, esi + 8]);          /* mov edx, [esi+0x8] */
            ii(0x1019_484e, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1019_4850, 2);  if(jnz(0x1019_4840, -0x12)) goto l_0x1019_4840;/* jnz 0x10194840 */
        l_0x1019_4852:
            ii(0x1019_4852, 3);  mov(edx, memd[ds, esi + 12]);         /* mov edx, [esi+0xc] */
            ii(0x1019_4855, 2);  cmp(ebx, edx);                        /* cmp ebx, edx */
            ii(0x1019_4857, 2);  if(jnz(0x1019_485f, 6)) goto l_0x1019_485f;/* jnz 0x1019485f */
            ii(0x1019_4859, 3);  mov(eax, memd[ds, edx + 4]);          /* mov eax, [edx+0x4] */
            ii(0x1019_485c, 3);  mov(memd[ds, esi + 12], eax);         /* mov [esi+0xc], eax */
        l_0x1019_485f:
            ii(0x1019_485f, 2);  cmp(ebp, memd[ds, ecx]);              /* cmp ebp, [ecx] */
            ii(0x1019_4861, 2);  if(jb(0x1019_486e, 0xb)) goto l_0x1019_486e;/* jb 0x1019486e */
            ii(0x1019_4863, 2);  mov(eax, ebp);                        /* mov eax, ebp */
            ii(0x1019_4865, 2);  mov(edx, memd[ds, ecx]);              /* mov edx, [ecx] */
            ii(0x1019_4867, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1019_4869, 3);  cmp(eax, 0xc);                        /* cmp eax, 0xc */
            ii(0x1019_486c, 2);  if(jae(0x1019_48a2, 0x34)) goto l_0x1019_48a2;/* jae 0x101948a2 */
        l_0x1019_486e:
            ii(0x1019_486e, 4);  mov(eax, memd[ss, esp + 12]);         /* mov eax, [esp+0xc] */
            ii(0x1019_4872, 4);  mov(edx, memd[ss, esp + 8]);          /* mov edx, [esp+0x8] */
            ii(0x1019_4876, 3);  mov(memd[ds, eax + 8], edx);          /* mov [eax+0x8], edx */
            ii(0x1019_4879, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1019_487b, 4);  mov(edx, memd[ss, esp + 12]);         /* mov edx, [esp+0xc] */
            ii(0x1019_487f, 3);  mov(memd[ds, eax + 4], edx);          /* mov [eax+0x4], edx */
            ii(0x1019_4882, 4);  mov(eax, memd[ss, esp + 4]);          /* mov eax, [esp+0x4] */
            ii(0x1019_4886, 2);  add(memd[ds, eax], ebp);              /* add [eax], ebp */
            ii(0x1019_4888, 3);  mov(eax, memd[ds, esi + 28]);         /* mov eax, [esi+0x1c] */
            ii(0x1019_488b, 1);  dec(eax);                             /* dec eax */
            ii(0x1019_488c, 2);  xor(dl, dl);                          /* xor dl, dl */
            ii(0x1019_488e, 3);  mov(memd[ds, esi + 28], eax);         /* mov [esi+0x1c], eax */
            ii(0x1019_4891, 6);  mov(memb[ds, 0x1020_a2d5], dl);       /* mov [0x1020a2d5], dl */
            ii(0x1019_4897, 2);  mov(edx, memd[ds, ecx]);              /* mov edx, [ecx] */
            ii(0x1019_4899, 2);  cmp(ebp, edx);                        /* cmp ebp, edx */
            ii(0x1019_489b, 2);  if(jb(0x1019_48dd, 0x40)) goto l_0x1019_48dd;/* jb 0x101948dd */
            ii(0x1019_489d, 5);  jmp(0x1019_4945, 0xa3); goto l_0x1019_4945;/* jmp 0x10194945 */
        l_0x1019_48a2:
            ii(0x1019_48a2, 2);  add(ebx, edx);                        /* add ebx, edx */
            ii(0x1019_48a4, 2);  mov(memd[ds, ebx], eax);              /* mov [ebx], eax */
            ii(0x1019_48a6, 4);  mov(eax, memd[ss, esp + 12]);         /* mov eax, [esp+0xc] */
            ii(0x1019_48aa, 3);  mov(memd[ds, ebx + 4], eax);          /* mov [ebx+0x4], eax */
            ii(0x1019_48ad, 4);  mov(eax, memd[ss, esp + 8]);          /* mov eax, [esp+0x8] */
            ii(0x1019_48b1, 3);  mov(memd[ds, ebx + 8], eax);          /* mov [ebx+0x8], eax */
            ii(0x1019_48b4, 4);  mov(eax, memd[ss, esp + 12]);         /* mov eax, [esp+0xc] */
            ii(0x1019_48b8, 3);  mov(memd[ds, eax + 8], ebx);          /* mov [eax+0x8], ebx */
            ii(0x1019_48bb, 4);  mov(eax, memd[ss, esp + 8]);          /* mov eax, [esp+0x8] */
            ii(0x1019_48bf, 3);  mov(memd[ds, eax + 4], ebx);          /* mov [eax+0x4], ebx */
            ii(0x1019_48c2, 4);  mov(edx, memd[ss, esp + 4]);          /* mov edx, [esp+0x4] */
            ii(0x1019_48c6, 2);  mov(eax, memd[ds, ecx]);              /* mov eax, [ecx] */
            ii(0x1019_48c8, 2);  mov(edi, memd[ds, edx]);              /* mov edi, [edx] */
            ii(0x1019_48ca, 2);  xor(ebp, ebp);                        /* xor ebp, ebp */
            ii(0x1019_48cc, 2);  add(edi, eax);                        /* add edi, eax */
            ii(0x1019_48ce, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1019_48d0, 2);  mov(memd[ds, edx], edi);              /* mov [edx], edi */
            ii(0x1019_48d2, 6);  mov(memb[ds, 0x1020_a2d5], ah);       /* mov [0x1020a2d5], ah */
            ii(0x1019_48d8, 5);  jmp(0x1019_4947, 0x6a); goto l_0x1019_4947;/* jmp 0x10194947 */
        l_0x1019_48dd:
            ii(0x1019_48dd, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1019_48df, 2);  sub(eax, ebp);                        /* sub eax, ebp */
            ii(0x1019_48e1, 2);  add(ebx, ebp);                        /* add ebx, ebp */
            ii(0x1019_48e3, 5);  jmp(0x1019_47fe, -0xea); goto l_0x1019_47fe;/* jmp 0x101947fe */
        l_0x1019_48e8:
            ii(0x1019_48e8, 5);  mov(ebp, 1);                          /* mov ebp, 0x1 */
            ii(0x1019_48ed, 2);  jmp(0x1019_4947, 0x58); goto l_0x1019_4947;/* jmp 0x10194947 */
        l_0x1019_48ef:
            ii(0x1019_48ef, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x1019_48f1, 3);  cmp(edx, 0xc);                        /* cmp edx, 0xc */
            ii(0x1019_48f4, 2);  if(jb(0x1019_4945, 0x4f)) goto l_0x1019_4945;/* jb 0x10194945 */
            ii(0x1019_48f6, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1019_48f8, 4);  mov(ecx, memd[ss, esp + 4]);          /* mov ecx, [esp+0x4] */
            ii(0x1019_48fc, 3);  or(bl, 1);                            /* or bl, 0x1 */
            ii(0x1019_48ff, 3);  or(dl, 1);                            /* or dl, 0x1 */
            ii(0x1019_4902, 2);  mov(memd[ds, ecx], ebx);              /* mov [ecx], ebx */
            ii(0x1019_4904, 3);  lea(ebx, memd[ds, ecx + eax]);        /* lea ebx, [ecx+eax] */
            ii(0x1019_4907, 5);  mov(eax, 0x101b_de0c);                /* mov eax, 0x101bde0c */
            ii(0x1019_490c, 4);  mov(memd[ss, esp + 4], ebx);          /* mov [esp+0x4], ebx */
            ii(0x1019_4910, 2);  mov(memd[ds, ebx], edx);              /* mov [ebx], edx */
            ii(0x1019_4912, 2);  mov(edx, ds);                         /* mov edx, ds */
            ii(0x1019_4914, 3);  mov(ebx, memd[ss, esp]);              /* mov ebx, [esp] */
            ii(0x1019_4917, 3);  cmp(dx, bx);                          /* cmp dx, bx */
            ii(0x1019_491a, 2);  if(jnz(0x1019_4936, 0x1a)) goto l_0x1019_4936;/* jnz 0x10194936 */
            ii(0x1019_491c, 6);  mov(esi, memd[ds, 0x101b_de0c]);      /* mov esi, [0x101bde0c] */
            ii(0x1019_4922, 2);  jmp(0x1019_492f, 0xb); goto l_0x1019_492f;/* jmp 0x1019492f */
        l_0x1019_4924:
            ii(0x1019_4924, 2);  cmp(esi, edi);                        /* cmp esi, edi */
            ii(0x1019_4926, 2);  if(ja(0x1019_492c, 4)) goto l_0x1019_492c;/* ja 0x1019492c */
            ii(0x1019_4928, 2);  cmp(edi, ecx);                        /* cmp edi, ecx */
            ii(0x1019_492a, 2);  if(jb(0x1019_4936, 0xa)) goto l_0x1019_4936;/* jb 0x10194936 */
        l_0x1019_492c:
            ii(0x1019_492c, 3);  mov(esi, memd[ds, esi + 8]);          /* mov esi, [esi+0x8] */
        l_0x1019_492f:
            ii(0x1019_492f, 3);  mov(ecx, memd[ds, esi + 8]);          /* mov ecx, [esi+0x8] */
            ii(0x1019_4932, 2);  test(ecx, ecx);                       /* test ecx, ecx */
            ii(0x1019_4934, 2);  if(jnz(0x1019_4924, -0x12)) goto l_0x1019_4924;/* jnz 0x10194924 */
        l_0x1019_4936:
            ii(0x1019_4936, 3);  inc(memd[ds, esi + 24]);              /* inc dword [esi+0x18] */
            ii(0x1019_4939, 4);  mov(eax, memd[ss, esp + 4]);          /* mov eax, [esp+0x4] */
            ii(0x1019_493d, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x1019_4940, 5);  call(Definitions.sys_free, -0x2_9884);/* call 0x1016b0c1 */
        l_0x1019_4945:
            ii(0x1019_4945, 2);  xor(ebp, ebp);                        /* xor ebp, ebp */
        l_0x1019_4947:
            ii(0x1019_4947, 2);  mov(eax, ebp);                        /* mov eax, ebp */
            ii(0x1019_4949, 3);  add(esp, 0x10);                       /* add esp, 0x10 */
            ii(0x1019_494c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1019_494d, 1);  pop(edi);                             /* pop edi */
            ii(0x1019_494e, 1);  pop(esi);                             /* pop esi */
            ii(0x1019_494f, 1);  ret();                                /* ret */
        }
    }
}

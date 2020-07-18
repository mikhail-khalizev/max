using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_5920-9b0fab10")]
        public void Method_1012_5920()
        {
            ii(0x1012_5920, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1012_5925, 5);  call(Definitions.sys_check_available_stack_size, 0x4_0428);/* call 0x10165d52 */
            ii(0x1012_592a, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_592b, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_592c, 1);  push(edx);                            /* push edx */
            ii(0x1012_592d, 1);  push(esi);                            /* push esi */
            ii(0x1012_592e, 1);  push(edi);                            /* push edi */
            ii(0x1012_592f, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_5930, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_5932, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1012_5938, 6);  mov(edx, memd[ds, 0x101c_586c]);      /* mov edx, [0x101c586c] */
            ii(0x1012_593e, 5);  mov(eax, memd[ds, 0x101c_5870]);      /* mov eax, [0x101c5870] */
            ii(0x1012_5943, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1012_5945, 2);  cmp(edx, memd[ds, eax]);              /* cmp edx, [eax] */
            ii(0x1012_5947, 2);  if(jnz(0x1012_5981, 0x38)) goto l_0x1012_5981;/* jnz 0x10125981 */
            ii(0x1012_5949, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_594b, 5);  mov(al, memb[ds, 0x101c_5631]);       /* mov al, [0x101c5631] */
            ii(0x1012_5950, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1012_5952, 2);  if(jz(0x1012_5975, 0x21)) goto l_0x1012_5975;/* jz 0x10125975 */
            ii(0x1012_5954, 5);  mov(eax, memd[ds, 0x101c_61a0]);      /* mov eax, [0x101c61a0] */
            ii(0x1012_5959, 5);  call(0x1014_85ad, 0x2_2c4f);          /* call 0x101485ad */
            ii(0x1012_595e, 5);  cmp(eax, 0x1f4);                      /* cmp eax, 0x1f4 */
            ii(0x1012_5963, 2);  if(jbe(0x1012_596e, 9)) goto l_0x1012_596e;/* jbe 0x1012596e */
            ii(0x1012_5965, 7);  cmp(memb[ds, 0x101c_59c9], 0);        /* cmp byte [0x101c59c9], 0x0 */
            ii(0x1012_596c, 2);  if(jnz(0x1012_5970, 2)) goto l_0x1012_5970;/* jnz 0x10125970 */
        l_0x1012_596e:
            ii(0x1012_596e, 2);  jmp(0x1012_5975, 5); goto l_0x1012_5975;/* jmp 0x10125975 */
        l_0x1012_5970:
            ii(0x1012_5970, 5);  call(0x1012_5807, -0x16e);            /* call 0x10125807 */
        l_0x1012_5975:
            ii(0x1012_5975, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1012_597c, 5);  jmp(0x1012_5bdd, 0x25c); goto l_0x1012_5bdd;/* jmp 0x10125bdd */
        l_0x1012_5981:
            ii(0x1012_5981, 6);  mov(edx, memd[ds, 0x101c_586c]);      /* mov edx, [0x101c586c] */
            ii(0x1012_5987, 5);  mov(eax, memd[ds, 0x101c_5870]);      /* mov eax, [0x101c5870] */
            ii(0x1012_598c, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1012_598e, 2);  cmp(edx, memd[ds, eax]);              /* cmp edx, [eax] */
            ii(0x1012_5990, 6);  if(jz(0x1012_5bcc, 0x236)) goto l_0x1012_5bcc;/* jz 0x10125bcc */
            ii(0x1012_5996, 5);  mov(eax, memd[ds, 0x101c_5870]);      /* mov eax, [0x101c5870] */
            ii(0x1012_599b, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1012_599d, 5);  mov(eax, memd[ds, 0x101c_5870]);      /* mov eax, [0x101c5870] */
            ii(0x1012_59a2, 2);  inc(memd[ds, eax]);                   /* inc dword [eax] */
            ii(0x1012_59a4, 5);  mov(eax, memd[ds, 0x101c_5980]);      /* mov eax, [0x101c5980] */
            ii(0x1012_59a9, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1012_59ab, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1012_59ad, 3);  mov(memb[ss, ebp - 4], al);           /* mov [ebp-0x4], al */
            ii(0x1012_59b0, 5);  mov(eax, memd[ds, 0x101c_5870]);      /* mov eax, [0x101c5870] */
            ii(0x1012_59b5, 6);  cmp(memd[ds, eax], 0x400);            /* cmp dword [eax], 0x400 */
            ii(0x1012_59bb, 2);  if(jnz(0x1012_59c8, 0xb)) goto l_0x1012_59c8;/* jnz 0x101259c8 */
            ii(0x1012_59bd, 5);  mov(eax, memd[ds, 0x101c_5870]);      /* mov eax, [0x101c5870] */
            ii(0x1012_59c2, 6);  mov(memd[ds, eax], 0);                /* mov dword [eax], 0x0 */
        l_0x1012_59c8:
            ii(0x1012_59c8, 5);  mov(al, memb[ds, 0x101c_5631]);       /* mov al, [0x101c5631] */
            ii(0x1012_59cd, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1012_59d0, 5);  jmp(0x1012_5bac, 0x1d7); goto l_0x1012_5bac;/* jmp 0x10125bac */
        l_0x1012_59d5:
            ii(0x1012_59d5, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_59d7, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_59da, 5);  cmp(eax, 0xff);                       /* cmp eax, 0xff */
            ii(0x1012_59df, 6);  if(jz(0x1012_5bc7, 0x1e2)) goto l_0x1012_5bc7;/* jz 0x10125bc7 */
            ii(0x1012_59e5, 7);  mov(memb[ds, 0x101c_5631], 0);        /* mov byte [0x101c5631], 0x0 */
        l_0x1012_59ec:
            ii(0x1012_59ec, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_59ef, 6);  cmp(al, memb[ds, 0x101c_59b9]);       /* cmp al, [0x101c59b9] */
            ii(0x1012_59f5, 2);  if(jnz(0x1012_5a08, 0x11)) goto l_0x1012_5a08;/* jnz 0x10125a08 */
            ii(0x1012_59f7, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_59fa, 5);  mov(memb[ds, 0x101c_5634], al);       /* mov [0x101c5634], al */
            ii(0x1012_59ff, 7);  mov(memb[ds, 0x101c_5631], 1);        /* mov byte [0x101c5631], 0x1 */
            ii(0x1012_5a06, 2);  jmp(0x1012_5a0d, 5); goto l_0x1012_5a0d;/* jmp 0x10125a0d */
        l_0x1012_5a08:
            ii(0x1012_5a08, 5);  call(0x1012_5807, -0x206);            /* call 0x10125807 */
        l_0x1012_5a0d:
            ii(0x1012_5a0d, 5);  jmp(0x1012_5bc7, 0x1b5); goto l_0x1012_5bc7;/* jmp 0x10125bc7 */
        l_0x1012_5a12:
            ii(0x1012_5a12, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1012_5a14, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_5a17, 6);  mov(memw[ds, 0x101c_5635], ax);       /* mov [0x101c5635], ax */
            ii(0x1012_5a1d, 7);  mov(memb[ds, 0x101c_5631], 2);        /* mov byte [0x101c5631], 0x2 */
            ii(0x1012_5a24, 5);  jmp(0x1012_5bc7, 0x19e); goto l_0x1012_5bc7;/* jmp 0x10125bc7 */
        l_0x1012_5a29:
            ii(0x1012_5a29, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1012_5a2b, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_5a2e, 3);  shl(eax, 8);                          /* shl eax, 0x8 */
            ii(0x1012_5a31, 7);  or(memw[ds, 0x101c_5635], ax);        /* or [0x101c5635], ax */
            ii(0x1012_5a38, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_5a3a, 6);  mov(ax, memw[ds, 0x101c_5635]);       /* mov ax, [0x101c5635] */
            ii(0x1012_5a40, 5);  cmp(eax, 0x226);                      /* cmp eax, 0x226 */
            ii(0x1012_5a45, 2);  if(jge(0x1012_5a62, 0x1b)) goto l_0x1012_5a62;/* jge 0x10125a62 */
            ii(0x1012_5a47, 9);  mov(memw[ds, 0x101c_5864], 0);        /* mov word [0x101c5864], 0x0 */
            ii(0x1012_5a50, 9);  mov(memw[ds, 0x101c_59b6], 0);        /* mov word [0x101c59b6], 0x0 */
            ii(0x1012_5a59, 7);  mov(memb[ds, 0x101c_5631], 3);        /* mov byte [0x101c5631], 0x3 */
            ii(0x1012_5a60, 2);  jmp(0x1012_5a67, 5); goto l_0x1012_5a67;/* jmp 0x10125a67 */
        l_0x1012_5a62:
            ii(0x1012_5a62, 5);  call(0x1012_5807, -0x260);            /* call 0x10125807 */
        l_0x1012_5a67:
            ii(0x1012_5a67, 5);  jmp(0x1012_5bc7, 0x15b); goto l_0x1012_5bc7;/* jmp 0x10125bc7 */
        l_0x1012_5a6c:
            ii(0x1012_5a6c, 6);  mov(ax, memw[ds, 0x101c_5864]);       /* mov ax, [0x101c5864] */
            ii(0x1012_5a72, 7);  inc(memw[ds, 0x101c_5864]);           /* inc word [0x101c5864] */
            ii(0x1012_5a79, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_5a7b, 3);  mov(dx, ax);                          /* mov dx, ax */
            ii(0x1012_5a7e, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_5a81, 6);  mov(memb[ds, edx + 0x101c_5637], al); /* mov [edx+0x101c5637], al */
            ii(0x1012_5a87, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_5a89, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_5a8c, 5);  call(0x100c_ddb2, -0x5_7cdf);         /* call 0x100cddb2 */
            ii(0x1012_5a91, 6);  mov(ax, memw[ds, 0x101c_5864]);       /* mov ax, [0x101c5864] */
            ii(0x1012_5a97, 7);  cmp(ax, memw[ds, 0x101c_5635]);       /* cmp ax, [0x101c5635] */
            ii(0x1012_5a9e, 2);  if(jnz(0x1012_5aa7, 7)) goto l_0x1012_5aa7;/* jnz 0x10125aa7 */
            ii(0x1012_5aa0, 7);  mov(memb[ds, 0x101c_5631], 4);        /* mov byte [0x101c5631], 0x4 */
        l_0x1012_5aa7:
            ii(0x1012_5aa7, 5);  jmp(0x1012_5bc7, 0x11b); goto l_0x1012_5bc7;/* jmp 0x10125bc7 */
        l_0x1012_5aac:
            ii(0x1012_5aac, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1012_5aae, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_5ab1, 6);  mov(memw[ds, 0x101c_5862], ax);       /* mov [0x101c5862], ax */
            ii(0x1012_5ab7, 7);  mov(memb[ds, 0x101c_5631], 5);        /* mov byte [0x101c5631], 0x5 */
            ii(0x1012_5abe, 5);  jmp(0x1012_5bc7, 0x104); goto l_0x1012_5bc7;/* jmp 0x10125bc7 */
        l_0x1012_5ac3:
            ii(0x1012_5ac3, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1012_5ac5, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_5ac8, 3);  shl(eax, 8);                          /* shl eax, 0x8 */
            ii(0x1012_5acb, 7);  or(memw[ds, 0x101c_5862], ax);        /* or [0x101c5862], ax */
            ii(0x1012_5ad2, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_5ad4, 5);  call(0x100c_ddb2, -0x5_7d27);         /* call 0x100cddb2 */
            ii(0x1012_5ad9, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1012_5ade, 5);  call(0x100c_ddb2, -0x5_7d31);         /* call 0x100cddb2 */
            ii(0x1012_5ae3, 7);  mov(memb[ds, 0x101c_5631], 0);        /* mov byte [0x101c5631], 0x0 */
            ii(0x1012_5aea, 6);  mov(ax, memw[ds, 0x101c_59b6]);       /* mov ax, [0x101c59b6] */
            ii(0x1012_5af0, 7);  cmp(ax, memw[ds, 0x101c_5862]);       /* cmp ax, [0x101c5862] */
            ii(0x1012_5af7, 2);  if(jz(0x1012_5b03, 0xa)) goto l_0x1012_5b03;/* jz 0x10125b03 */
            ii(0x1012_5af9, 5);  call(0x1012_5807, -0x2f7);            /* call 0x10125807 */
            ii(0x1012_5afe, 5);  jmp(0x1012_5bc7, 0xc4); goto l_0x1012_5bc7;/* jmp 0x10125bc7 */
        l_0x1012_5b03:
            ii(0x1012_5b03, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_5b05, 5);  mov(al, memb[ds, 0x101c_5637]);       /* mov al, [0x101c5637] */
            ii(0x1012_5b0a, 5);  cmp(eax, 0xff);                       /* cmp eax, 0xff */
            ii(0x1012_5b0f, 2);  if(jnz(0x1012_5b29, 0x18)) goto l_0x1012_5b29;/* jnz 0x10125b29 */
            ii(0x1012_5b11, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_5b13, 5);  mov(al, memb[ds, 0x101c_5638]);       /* mov al, [0x101c5638] */
            ii(0x1012_5b18, 5);  call(0x1012_5871, -0x2ac);            /* call 0x10125871 */
            ii(0x1012_5b1d, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1012_5b24, 5);  jmp(0x1012_5bdd, 0xb4); goto l_0x1012_5bdd;/* jmp 0x10125bdd */
        l_0x1012_5b29:
            ii(0x1012_5b29, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1012_5b2b, 7);  mov(bx, memw[ds, 0x101c_5864]);       /* mov bx, [0x101c5864] */
            ii(0x1012_5b32, 5);  mov(edx, 0x101c_5637);                /* mov edx, 0x101c5637 */
            ii(0x1012_5b37, 5);  mov(eax, 0x101c_59f0);                /* mov eax, 0x101c59f0 */
            ii(0x1012_5b3c, 5);  call(Definitions.sys_memcpy, 0x4_030a);/* call 0x10165e4b */
            ii(0x1012_5b41, 5);  mov(al, memb[ds, 0x101c_59b9]);       /* mov al, [0x101c59b9] */
            ii(0x1012_5b46, 2);  inc(al);                              /* inc al */
            ii(0x1012_5b48, 2);  and(al, 0x3f);                        /* and al, 0x3f */
            ii(0x1012_5b4a, 5);  mov(memb[ds, 0x101c_59b9], al);       /* mov [0x101c59b9], al */
            ii(0x1012_5b4f, 7);  mov(memd[ss, ebp - 8], 1);            /* mov dword [ebp-0x8], 0x1 */
            ii(0x1012_5b56, 5);  jmp(0x1012_5bdd, 0x82); goto l_0x1012_5bdd;/* jmp 0x10125bdd */
        l_0x1012_5b5b:
            ii(0x1012_5b5b, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_5b5d, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_5b60, 5);  cmp(eax, 0xff);                       /* cmp eax, 0xff */
            ii(0x1012_5b65, 2);  if(jnz(0x1012_5b81, 0x1a)) goto l_0x1012_5b81;/* jnz 0x10125b81 */
            ii(0x1012_5b67, 6);  dec(memb[ds, 0x101c_61a8]);           /* dec byte [0x101c61a8] */
            ii(0x1012_5b6d, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_5b6f, 5);  mov(al, memb[ds, 0x101c_61a8]);       /* mov al, [0x101c61a8] */
            ii(0x1012_5b74, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1012_5b76, 2);  if(jnz(0x1012_5b7f, 7)) goto l_0x1012_5b7f;/* jnz 0x10125b7f */
            ii(0x1012_5b78, 7);  mov(memb[ds, 0x101c_5631], 7);        /* mov byte [0x101c5631], 0x7 */
        l_0x1012_5b7f:
            ii(0x1012_5b7f, 2);  jmp(0x1012_5b88, 7); goto l_0x1012_5b88;/* jmp 0x10125b88 */
        l_0x1012_5b81:
            ii(0x1012_5b81, 7);  mov(memb[ds, 0x101c_61a8], 4);        /* mov byte [0x101c61a8], 0x4 */
        l_0x1012_5b88:
            ii(0x1012_5b88, 2);  jmp(0x1012_5bc7, 0x3d); goto l_0x1012_5bc7;/* jmp 0x10125bc7 */
        l_0x1012_5b8a:
            ii(0x1012_5b8a, 2);  jmp(0x1012_5bc7, 0x3b); goto l_0x1012_5bc7;/* jmp 0x10125bc7 */
        //  ii(0x1012_5b8c, 32);  Недостижимый код.
        l_0x1012_5bac:
            ii(0x1012_5bac, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1012_5baf, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
            ii(0x1012_5bb2, 4);  cmp(memb[ss, ebp - 16], 7);           /* cmp byte [ebp-0x10], 0x7 */
            ii(0x1012_5bb6, 2);  if(ja(0x1012_5b8a, -0x2e)) goto l_0x1012_5b8a;/* ja 0x10125b8a */
            ii(0x1012_5bb8, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_5bba, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1012_5bbd, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1012_5bc0, 7);  /* jmp dword [cs:eax+0x10125b8c] */
            switch (jmp_abs_switch(memd[cs, eax + 0x1012_5b8c]))
            {
                case 0x1012_59d5:
                    goto l_0x1012_59d5;
                case 0x1012_59ec:
                    goto l_0x1012_59ec;
                case 0x1012_5a12:
                    goto l_0x1012_5a12;
                case 0x1012_5a29:
                    goto l_0x1012_5a29;
                case 0x1012_5a6c:
                    goto l_0x1012_5a6c;
                case 0x1012_5aac:
                    goto l_0x1012_5aac;
                case 0x1012_5ac3:
                    goto l_0x1012_5ac3;
                case 0x1012_5b5b:
                    goto l_0x1012_5b5b;
                default:
                    throw new NotImplementedException();
            }
        l_0x1012_5bc7:
            ii(0x1012_5bc7, 5);  jmp(0x1012_5981, -0x24b); goto l_0x1012_5981;/* jmp 0x10125981 */
        l_0x1012_5bcc:
            ii(0x1012_5bcc, 5);  call(0x1014_82f4, 0x2_2723);          /* call 0x101482f4 */
            ii(0x1012_5bd1, 5);  mov(memd[ds, 0x101c_61a0], eax);      /* mov [0x101c61a0], eax */
            ii(0x1012_5bd6, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
        l_0x1012_5bdd:
            ii(0x1012_5bdd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_5be0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_5be2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_5be3, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_5be4, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_5be5, 1);  pop(edx);                             /* pop edx */
            ii(0x1012_5be6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_5be7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_5be8, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_7fb2-bab382d7")]
        public void Method_100f_7fb2()
        {
            ii(0x100f_7fb2, 5);  push(0xc8);                           /* push 0xc8 */
            ii(0x100f_7fb7, 5);  call(Definitions.sys_check_available_stack_size, 0x6_dd96);/* call 0x10165d52 */
            ii(0x100f_7fbc, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_7fbd, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_7fbe, 1);  push(esi);                            /* push esi */
            ii(0x100f_7fbf, 1);  push(edi);                            /* push edi */
            ii(0x100f_7fc0, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_7fc1, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_7fc3, 6);  sub(esp, 0xb0);                       /* sub esp, 0xb0 */
            ii(0x100f_7fc9, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_7fcc, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100f_7fcf, 5);  mov(ecx, 0x40_0000);                  /* mov ecx, 0x400000 */
            ii(0x100f_7fd4, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_7fd6, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_7fdb, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x100f_7fde, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100f_7fe2, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_7fe6, 5);  call(0x1007_388b, -0x8_4760);         /* call 0x1007388b */
            ii(0x100f_7feb, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_7fee, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7ff1, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100f_7ff4, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100f_7ff8, 2);  if(jnz(0x100f_8017, 0x1d)) goto l_0x100f_8017;/* jnz 0x100f8017 */
            ii(0x100f_7ffa, 5);  mov(ecx, 0x40_0000);                  /* mov ecx, 0x400000 */
            ii(0x100f_7fff, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_8003, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100f_8007, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_8009, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_800e, 1);  cwde();                               /* cwde */
            ii(0x100f_800f, 5);  call(0x1007_459a, -0x8_3a7a);         /* call 0x1007459a */
            ii(0x100f_8014, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
        l_0x100f_8017:
            ii(0x100f_8017, 5);  mov(edx, 0x101c_38bc);                /* mov edx, 0x101c38bc */
            ii(0x100f_801c, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_801f, 5);  call(0x1008_b4b4, -0x6_cb70);         /* call 0x1008b4b4 */
            ii(0x100f_8024, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_8026, 2);  if(jz(0x100f_8063, 0x3b)) goto l_0x100f_8063;/* jz 0x100f8063 */
            ii(0x100f_8028, 4);  mov(memb[ss, ebp - 120], 0);          /* mov byte [ebp-0x78], 0x0 */
            ii(0x100f_802c, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100f_8030, 2);  if(jz(0x100f_803d, 0xb)) goto l_0x100f_803d;/* jz 0x100f803d */
            ii(0x100f_8032, 3);  lea(edx, memd[ss, ebp - 120]);        /* lea edx, [ebp-0x78] */
            ii(0x100f_8035, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_8038, 5);  call(0x1014_fa43, 0x5_7a06);          /* call 0x1014fa43 */
        l_0x100f_803d:
            ii(0x100f_803d, 5);  call(0x1010_2a34, 0xa9f2);            /* call 0x10102a34 */
            ii(0x100f_8042, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x100f_8044, 5);  mov(ebx, 0xa2);                       /* mov ebx, 0xa2 */
            ii(0x100f_8049, 3);  lea(edx, memd[ss, ebp - 120]);        /* lea edx, [ebp-0x78] */
            ii(0x100f_804c, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100f_8051, 5);  call(0x100f_3176, -0x4ee0);           /* call 0x100f3176 */
            ii(0x100f_8056, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x100f_8059, 5);  mov(eax, 0x101c_38bc);                /* mov eax, 0x101c38bc */
            ii(0x100f_805e, 5);  call(0x1007_6630, -0x8_1a33);         /* call 0x10076630 */
        l_0x100f_8063:
            ii(0x100f_8063, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_8066, 6);  mov(memw[ds, 0x101c_3908], ax);       /* mov [0x101c3908], ax */
            ii(0x100f_806c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_806f, 6);  mov(memw[ds, 0x101c_390a], ax);       /* mov [0x101c390a], ax */
            ii(0x100f_8075, 7);  cmp(memb[ds, 0x101c_391e], 9);        /* cmp byte [0x101c391e], 0x9 */
            ii(0x100f_807c, 2);  if(jnz(0x100f_808a, 0xc)) goto l_0x100f_808a;/* jnz 0x100f808a */
            ii(0x100f_807e, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_8080, 5);  mov(al, memb[ds, 0x101c_37c9]);       /* mov al, [0x101c37c9] */
            ii(0x100f_8085, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x100f_8088, 2);  if(jnz(0x100f_80a7, 0x1d)) goto l_0x100f_80a7;/* jnz 0x100f80a7 */
        l_0x100f_808a:
            ii(0x100f_808a, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_808c, 5);  mov(al, memb[ds, 0x101c_37c8]);       /* mov al, [0x101c37c8] */
            ii(0x100f_8091, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100f_8097, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_809d, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100f_80a2, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x100f_80a5, 2);  if(jz(0x100f_80c2, 0x1b)) goto l_0x100f_80c2;/* jz 0x100f80c2 */
        l_0x100f_80a7:
            ii(0x100f_80a7, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_80ab, 2);  if(jz(0x100f_80b3, 6)) goto l_0x100f_80b3;/* jz 0x100f80b3 */
            ii(0x100f_80ad, 4);  mov(memb[ss, ebp - 124], 0x11);       /* mov byte [ebp-0x7c], 0x11 */
            ii(0x100f_80b1, 2);  jmp(0x100f_80b7, 4); goto l_0x100f_80b7;/* jmp 0x100f80b7 */
        l_0x100f_80b3:
            ii(0x100f_80b3, 4);  mov(memb[ss, ebp - 124], 0x15);       /* mov byte [ebp-0x7c], 0x15 */
        l_0x100f_80b7:
            ii(0x100f_80b7, 3);  mov(al, memb[ss, ebp - 124]);         /* mov al, [ebp-0x7c] */
            ii(0x100f_80ba, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x100f_80bd, 5);  jmp(0x100f_8b88, 0xac6); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_80c2:
            ii(0x100f_80c2, 7);  cmp(memb[ds, 0x101c_37d4], 0);        /* cmp byte [0x101c37d4], 0x0 */
            ii(0x100f_80c9, 2);  if(jz(0x100f_80d4, 9)) goto l_0x100f_80d4;/* jz 0x100f80d4 */
            ii(0x100f_80cb, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x100f_80cf, 5);  jmp(0x100f_8b88, 0xab4); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_80d4:
            ii(0x100f_80d4, 7);  cmp(memb[ds, 0x101c_391e], 7);        /* cmp byte [0x101c391e], 0x7 */
            ii(0x100f_80db, 2);  if(jnz(0x100f_8100, 0x23)) goto l_0x100f_8100;/* jnz 0x100f8100 */
            ii(0x100f_80dd, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100f_80e1, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_80e5, 5);  call(0x100f_7ed6, -0x214);            /* call 0x100f7ed6 */
            ii(0x100f_80ea, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_80ec, 2);  if(jz(0x100f_80f7, 9)) goto l_0x100f_80f7;/* jz 0x100f80f7 */
            ii(0x100f_80ee, 4);  mov(memb[ss, ebp - 12], 0x14);        /* mov byte [ebp-0xc], 0x14 */
            ii(0x100f_80f2, 5);  jmp(0x100f_8b88, 0xa91); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_80f7:
            ii(0x100f_80f7, 4);  mov(memb[ss, ebp - 12], 0x15);        /* mov byte [ebp-0xc], 0x15 */
            ii(0x100f_80fb, 5);  jmp(0x100f_8b88, 0xa88); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_8100:
            ii(0x100f_8100, 7);  cmp(memb[ds, 0x101c_38a2], 0);        /* cmp byte [0x101c38a2], 0x0 */
            ii(0x100f_8107, 6);  if(jz(0x100f_81b7, 0xaa)) goto l_0x100f_81b7;/* jz 0x100f81b7 */
            ii(0x100f_810d, 5);  mov(eax, memd[ds, 0x101c_3898]);      /* mov eax, [0x101c3898] */
            ii(0x100f_8112, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100f_8115, 6);  cmp(eax, memd[ds, 0x101c_38cc]);      /* cmp eax, [0x101c38cc] */
            ii(0x100f_811b, 2);  if(jnz(0x100f_8131, 0x14)) goto l_0x100f_8131;/* jnz 0x100f8131 */
            ii(0x100f_811d, 5);  mov(eax, memd[ds, 0x101c_389a]);      /* mov eax, [0x101c389a] */
            ii(0x100f_8122, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100f_8125, 6);  cmp(eax, memd[ds, 0x101c_38d0]);      /* cmp eax, [0x101c38d0] */
            ii(0x100f_812b, 6);  if(jz(0x100f_81a5, 0x74)) goto l_0x100f_81a5;/* jz 0x100f81a5 */
        l_0x100f_8131:
            ii(0x100f_8131, 7);  cmp(memb[ds, 0x101c_38a2], 1);        /* cmp byte [0x101c38a2], 0x1 */
            ii(0x100f_8138, 2);  if(jnz(0x100f_8171, 0x37)) goto l_0x100f_8171;/* jnz 0x100f8171 */
            ii(0x100f_813a, 5);  mov(eax, memd[ds, 0x101c_3898]);      /* mov eax, [0x101c3898] */
            ii(0x100f_813f, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100f_8142, 6);  sub(eax, memd[ds, 0x101c_38cc]);      /* sub eax, [0x101c38cc] */
            ii(0x100f_8148, 5);  call(/* sys */ 0x1016_5df8, 0x6_dcab);/* call 0x10165df8 */
            ii(0x100f_814d, 3);  cmp(eax, 0x10);                       /* cmp eax, 0x10 */
            ii(0x100f_8150, 2);  if(jg(0x100f_816a, 0x18)) goto l_0x100f_816a;/* jg 0x100f816a */
            ii(0x100f_8152, 5);  mov(eax, memd[ds, 0x101c_389a]);      /* mov eax, [0x101c389a] */
            ii(0x100f_8157, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100f_815a, 6);  sub(eax, memd[ds, 0x101c_38d0]);      /* sub eax, [0x101c38d0] */
            ii(0x100f_8160, 5);  call(/* sys */ 0x1016_5df8, 0x6_dc93);/* call 0x10165df8 */
            ii(0x100f_8165, 3);  cmp(eax, 0x10);                       /* cmp eax, 0x10 */
            ii(0x100f_8168, 2);  if(jle(0x100f_8171, 7)) goto l_0x100f_8171;/* jle 0x100f8171 */
        l_0x100f_816a:
            ii(0x100f_816a, 7);  mov(memb[ds, 0x101c_38a2], 2);        /* mov byte [0x101c38a2], 0x2 */
        l_0x100f_8171:
            ii(0x100f_8171, 7);  cmp(memb[ds, 0x101c_38a2], 2);        /* cmp byte [0x101c38a2], 0x2 */
            ii(0x100f_8178, 2);  if(jnz(0x100f_81a5, 0x2b)) goto l_0x100f_81a5;/* jnz 0x100f81a5 */
            ii(0x100f_817a, 6);  mov(ax, memw[ds, 0x101c_38cc]);       /* mov ax, [0x101c38cc] */
            ii(0x100f_8180, 6);  mov(memw[ds, 0x101c_389a], ax);       /* mov [0x101c389a], ax */
            ii(0x100f_8186, 6);  mov(ax, memw[ds, 0x101c_38d0]);       /* mov ax, [0x101c38d0] */
            ii(0x100f_818c, 6);  mov(memw[ds, 0x101c_389c], ax);       /* mov [0x101c389c], ax */
            ii(0x100f_8192, 7);  mov(memb[ds, 0x101c_38a3], 1);        /* mov byte [0x101c38a3], 0x1 */
            ii(0x100f_8199, 7);  mov(memb[ds, 0x101c_391a], 1);        /* mov byte [0x101c391a], 0x1 */
            ii(0x100f_81a0, 5);  call(0x100f_40a6, -0x40ff);           /* call 0x100f40a6 */
        l_0x100f_81a5:
            ii(0x100f_81a5, 7);  cmp(memb[ds, 0x101c_38a2], 2);        /* cmp byte [0x101c38a2], 0x2 */
            ii(0x100f_81ac, 2);  if(jnz(0x100f_81b7, 9)) goto l_0x100f_81b7;/* jnz 0x100f81b7 */
            ii(0x100f_81ae, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x100f_81b2, 5);  jmp(0x100f_8b88, 0x9d1); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_81b7:
            ii(0x100f_81b7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_81b9, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_81be, 5);  call(0x1013_ad11, 0x4_2b4e);          /* call 0x1013ad11 */
            ii(0x100f_81c3, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_81c5, 2);  if(jnz(0x100f_81e9, 0x22)) goto l_0x100f_81e9;/* jnz 0x100f81e9 */
            ii(0x100f_81c7, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_81cc, 5);  call(0x1007_6574, -0x8_1c5d);         /* call 0x10076574 */
            ii(0x100f_81d1, 4);  cmp(memb[ds, eax + 61], 2);           /* cmp byte [eax+0x3d], 0x2 */
            ii(0x100f_81d5, 2);  if(jnz(0x100f_81e7, 0x10)) goto l_0x100f_81e7;/* jnz 0x100f81e7 */
            ii(0x100f_81d7, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_81dc, 5);  call(0x1007_6574, -0x8_1c6d);         /* call 0x10076574 */
            ii(0x100f_81e1, 4);  cmp(memb[ds, eax + 62], 1);           /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100f_81e5, 2);  if(jnz(0x100f_81e9, 2)) goto l_0x100f_81e9;/* jnz 0x100f81e9 */
        l_0x100f_81e7:
            ii(0x100f_81e7, 2);  jmp(0x100f_81eb, 2); goto l_0x100f_81eb;/* jmp 0x100f81eb */
        l_0x100f_81e9:
            ii(0x100f_81e9, 2);  jmp(0x100f_820d, 0x22); goto l_0x100f_820d;/* jmp 0x100f820d */
        l_0x100f_81eb:
            ii(0x100f_81eb, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_81f0, 5);  call(0x1007_6574, -0x8_1c81);         /* call 0x10076574 */
            ii(0x100f_81f5, 4);  cmp(memb[ds, eax + 61], 0x1b);        /* cmp byte [eax+0x3d], 0x1b */
            ii(0x100f_81f9, 2);  if(jnz(0x100f_820b, 0x10)) goto l_0x100f_820b;/* jnz 0x100f820b */
            ii(0x100f_81fb, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8200, 5);  call(0x1007_6574, -0x8_1c91);         /* call 0x10076574 */
            ii(0x100f_8205, 4);  cmp(memb[ds, eax + 62], 1);           /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100f_8209, 2);  if(jnz(0x100f_820d, 2)) goto l_0x100f_820d;/* jnz 0x100f820d */
        l_0x100f_820b:
            ii(0x100f_820b, 2);  jmp(0x100f_820f, 2); goto l_0x100f_820f;/* jmp 0x100f820f */
        l_0x100f_820d:
            ii(0x100f_820d, 2);  jmp(0x100f_8231, 0x22); goto l_0x100f_8231;/* jmp 0x100f8231 */
        l_0x100f_820f:
            ii(0x100f_820f, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8214, 5);  call(0x1007_6574, -0x8_1ca5);         /* call 0x10076574 */
            ii(0x100f_8219, 4);  cmp(memb[ds, eax + 61], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x100f_821d, 2);  if(jnz(0x100f_822f, 0x10)) goto l_0x100f_822f;/* jnz 0x100f822f */
            ii(0x100f_821f, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8224, 5);  call(0x1007_6574, -0x8_1cb5);         /* call 0x10076574 */
            ii(0x100f_8229, 4);  cmp(memb[ds, eax + 62], 1);           /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100f_822d, 2);  if(jnz(0x100f_8231, 2)) goto l_0x100f_8231;/* jnz 0x100f8231 */
        l_0x100f_822f:
            ii(0x100f_822f, 2);  jmp(0x100f_8233, 2); goto l_0x100f_8233;/* jmp 0x100f8233 */
        l_0x100f_8231:
            ii(0x100f_8231, 2);  jmp(0x100f_8243, 0x10); goto l_0x100f_8243;/* jmp 0x100f8243 */
        l_0x100f_8233:
            ii(0x100f_8233, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8238, 5);  call(0x1007_6574, -0x8_1cc9);         /* call 0x10076574 */
            ii(0x100f_823d, 4);  cmp(memb[ds, eax + 61], 3);           /* cmp byte [eax+0x3d], 0x3 */
            ii(0x100f_8241, 2);  if(jnz(0x100f_8245, 2)) goto l_0x100f_8245;/* jnz 0x100f8245 */
        l_0x100f_8243:
            ii(0x100f_8243, 2);  jmp(0x100f_8255, 0x10); goto l_0x100f_8255;/* jmp 0x100f8255 */
        l_0x100f_8245:
            ii(0x100f_8245, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_824a, 5);  call(0x1007_6574, -0x8_1cdb);         /* call 0x10076574 */
            ii(0x100f_824f, 4);  cmp(memb[ds, eax + 61], 9);           /* cmp byte [eax+0x3d], 0x9 */
            ii(0x100f_8253, 2);  if(jnz(0x100f_8257, 2)) goto l_0x100f_8257;/* jnz 0x100f8257 */
        l_0x100f_8255:
            ii(0x100f_8255, 2);  jmp(0x100f_8267, 0x10); goto l_0x100f_8267;/* jmp 0x100f8267 */
        l_0x100f_8257:
            ii(0x100f_8257, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_825c, 5);  call(0x1007_6574, -0x8_1ced);         /* call 0x10076574 */
            ii(0x100f_8261, 4);  cmp(memb[ds, eax + 62], 0xe);         /* cmp byte [eax+0x3e], 0xe */
            ii(0x100f_8265, 2);  if(jnz(0x100f_8269, 2)) goto l_0x100f_8269;/* jnz 0x100f8269 */
        l_0x100f_8267:
            ii(0x100f_8267, 2);  jmp(0x100f_8279, 0x10); goto l_0x100f_8279;/* jmp 0x100f8279 */
        l_0x100f_8269:
            ii(0x100f_8269, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_826e, 5);  call(0x1007_6574, -0x8_1cff);         /* call 0x10076574 */
            ii(0x100f_8273, 4);  cmp(memb[ds, eax + 61], 0x1a);        /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100f_8277, 2);  if(jnz(0x100f_827b, 2)) goto l_0x100f_827b;/* jnz 0x100f827b */
        l_0x100f_8279:
            ii(0x100f_8279, 2);  jmp(0x100f_828b, 0x10); goto l_0x100f_828b;/* jmp 0x100f828b */
        l_0x100f_827b:
            ii(0x100f_827b, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8280, 5);  call(0x1007_6574, -0x8_1d11);         /* call 0x10076574 */
            ii(0x100f_8285, 4);  cmp(memb[ds, eax + 61], 0x19);        /* cmp byte [eax+0x3d], 0x19 */
            ii(0x100f_8289, 2);  if(jnz(0x100f_828d, 2)) goto l_0x100f_828d;/* jnz 0x100f828d */
        l_0x100f_828b:
            ii(0x100f_828b, 2);  jmp(0x100f_829d, 0x10); goto l_0x100f_829d;/* jmp 0x100f829d */
        l_0x100f_828d:
            ii(0x100f_828d, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8292, 5);  call(0x1007_6574, -0x8_1d23);         /* call 0x10076574 */
            ii(0x100f_8297, 4);  cmp(memb[ds, eax + 61], 0x18);        /* cmp byte [eax+0x3d], 0x18 */
            ii(0x100f_829b, 2);  if(jnz(0x100f_829f, 2)) goto l_0x100f_829f;/* jnz 0x100f829f */
        l_0x100f_829d:
            ii(0x100f_829d, 2);  jmp(0x100f_82af, 0x10); goto l_0x100f_82af;/* jmp 0x100f82af */
        l_0x100f_829f:
            ii(0x100f_829f, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_82a4, 5);  call(0x1007_6574, -0x8_1d35);         /* call 0x10076574 */
            ii(0x100f_82a9, 4);  cmp(memb[ds, eax + 61], 0xf);         /* cmp byte [eax+0x3d], 0xf */
            ii(0x100f_82ad, 2);  if(jnz(0x100f_82b1, 2)) goto l_0x100f_82b1;/* jnz 0x100f82b1 */
        l_0x100f_82af:
            ii(0x100f_82af, 2);  jmp(0x100f_82c1, 0x10); goto l_0x100f_82c1;/* jmp 0x100f82c1 */
        l_0x100f_82b1:
            ii(0x100f_82b1, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_82b6, 5);  call(0x1007_6574, -0x8_1d47);         /* call 0x10076574 */
            ii(0x100f_82bb, 4);  cmp(memb[ds, eax + 61], 0x16);        /* cmp byte [eax+0x3d], 0x16 */
            ii(0x100f_82bf, 2);  if(jnz(0x100f_82c3, 2)) goto l_0x100f_82c3;/* jnz 0x100f82c3 */
        l_0x100f_82c1:
            ii(0x100f_82c1, 2);  jmp(0x100f_82e1, 0x1e); goto l_0x100f_82e1;/* jmp 0x100f82e1 */
        l_0x100f_82c3:
            ii(0x100f_82c3, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_82c8, 5);  call(0x1007_6574, -0x8_1d59);         /* call 0x10076574 */
            ii(0x100f_82cd, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_82cf, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x100f_82d2, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_82d4, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_82d9, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100f_82db, 6);  if(jz(0x100f_838b, 0xaa)) goto l_0x100f_838b;/* jz 0x100f838b */
        l_0x100f_82e1:
            ii(0x100f_82e1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_82e3, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_82e8, 5);  call(0x1013_ad71, 0x4_2a84);          /* call 0x1013ad71 */
            ii(0x100f_82ed, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_82ef, 2);  if(jz(0x100f_8302, 0x11)) goto l_0x100f_8302;/* jz 0x100f8302 */
            ii(0x100f_82f1, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100f_82f4, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_82f9, 5);  call(0x1007_6e00, -0x8_14fe);         /* call 0x10076e00 */
            ii(0x100f_82fe, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_8300, 2);  if(jnz(0x100f_8304, 2)) goto l_0x100f_8304;/* jnz 0x100f8304 */
        l_0x100f_8302:
            ii(0x100f_8302, 2);  jmp(0x100f_8314, 0x10); goto l_0x100f_8314;/* jmp 0x100f8314 */
        l_0x100f_8304:
            ii(0x100f_8304, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8309, 5);  call(0x1007_6574, -0x8_1d9a);         /* call 0x10076574 */
            ii(0x100f_830e, 4);  cmp(memb[ds, eax + 61], 0x1a);        /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100f_8312, 2);  if(jnz(0x100f_8316, 2)) goto l_0x100f_8316;/* jnz 0x100f8316 */
        l_0x100f_8314:
            ii(0x100f_8314, 2);  jmp(0x100f_831f, 9); goto l_0x100f_831f;/* jmp 0x100f831f */
        l_0x100f_8316:
            ii(0x100f_8316, 4);  mov(memb[ss, ebp - 12], 0x15);        /* mov byte [ebp-0xc], 0x15 */
            ii(0x100f_831a, 5);  jmp(0x100f_8b88, 0x869); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_831f:
            ii(0x100f_831f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_8321, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8326, 5);  call(0x1013_ad71, 0x4_2a46);          /* call 0x1013ad71 */
            ii(0x100f_832b, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_832d, 2);  if(jz(0x100f_8335, 6)) goto l_0x100f_8335;/* jz 0x100f8335 */
            ii(0x100f_832f, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_8333, 2);  if(jnz(0x100f_8337, 2)) goto l_0x100f_8337;/* jnz 0x100f8337 */
        l_0x100f_8335:
            ii(0x100f_8335, 2);  jmp(0x100f_8370, 0x39); goto l_0x100f_8370;/* jmp 0x100f8370 */
        l_0x100f_8337:
            ii(0x100f_8337, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_833c, 5);  call(0x1007_6574, -0x8_1dcd);         /* call 0x10076574 */
            ii(0x100f_8341, 5);  call(0x1007_61d4, -0x8_2172);         /* call 0x100761d4 */
            ii(0x100f_8346, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100f_8348, 2);  if(jz(0x100f_8370, 0x26)) goto l_0x100f_8370;/* jz 0x100f8370 */
            ii(0x100f_834a, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_834f, 5);  call(0x1007_6574, -0x8_1de0);         /* call 0x10076574 */
            ii(0x100f_8354, 5);  call(0x1007_61d4, -0x8_2185);         /* call 0x100761d4 */
            ii(0x100f_8359, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100f_835b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_835e, 5);  call(0x1007_61d4, -0x8_218f);         /* call 0x100761d4 */
            ii(0x100f_8363, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100f_8365, 2);  if(jnz(0x100f_8370, 9)) goto l_0x100f_8370;/* jnz 0x100f8370 */
            ii(0x100f_8367, 4);  mov(memb[ss, ebp - 12], 0x15);        /* mov byte [ebp-0xc], 0x15 */
            ii(0x100f_836b, 5);  jmp(0x100f_8b88, 0x818); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_8370:
            ii(0x100f_8370, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_8374, 2);  if(jz(0x100f_837c, 6)) goto l_0x100f_837c;/* jz 0x100f837c */
            ii(0x100f_8376, 4);  mov(memb[ss, ebp - 128], 0x11);       /* mov byte [ebp-0x80], 0x11 */
            ii(0x100f_837a, 2);  jmp(0x100f_8380, 4); goto l_0x100f_8380;/* jmp 0x100f8380 */
        l_0x100f_837c:
            ii(0x100f_837c, 4);  mov(memb[ss, ebp - 128], 0x15);       /* mov byte [ebp-0x80], 0x15 */
        l_0x100f_8380:
            ii(0x100f_8380, 3);  mov(al, memb[ss, ebp - 128]);         /* mov al, [ebp-0x80] */
            ii(0x100f_8383, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x100f_8386, 5);  jmp(0x100f_8b88, 0x7fd); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_838b:
            ii(0x100f_838b, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8390, 5);  call(0x1007_65d0, -0x8_1dc5);         /* call 0x100765d0 */
            ii(0x100f_8395, 5);  call(0x1007_5d35, -0x8_2665);         /* call 0x10075d35 */
            ii(0x100f_839a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100f_839c, 2);  if(jz(0x100f_83ee, 0x50)) goto l_0x100f_83ee;/* jz 0x100f83ee */
            ii(0x100f_839e, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_83a2, 2);  if(jz(0x100f_83ca, 0x26)) goto l_0x100f_83ca;/* jz 0x100f83ca */
            ii(0x100f_83a4, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_83a9, 5);  call(0x1007_6574, -0x8_1e3a);         /* call 0x10076574 */
            ii(0x100f_83ae, 5);  call(0x1007_61d4, -0x8_21df);         /* call 0x100761d4 */
            ii(0x100f_83b3, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100f_83b5, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_83b8, 5);  call(0x1007_61d4, -0x8_21e9);         /* call 0x100761d4 */
            ii(0x100f_83bd, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100f_83bf, 2);  if(jnz(0x100f_83ca, 9)) goto l_0x100f_83ca;/* jnz 0x100f83ca */
            ii(0x100f_83c1, 4);  mov(memb[ss, ebp - 12], 0x15);        /* mov byte [ebp-0xc], 0x15 */
            ii(0x100f_83c5, 5);  jmp(0x100f_8b88, 0x7be); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_83ca:
            ii(0x100f_83ca, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_83ce, 2);  if(jz(0x100f_83d9, 9)) goto l_0x100f_83d9;/* jz 0x100f83d9 */
            ii(0x100f_83d0, 7);  mov(memb[ss, ebp - 132], 0x11);       /* mov byte [ebp-0x84], 0x11 */
            ii(0x100f_83d7, 2);  jmp(0x100f_83e0, 7); goto l_0x100f_83e0;/* jmp 0x100f83e0 */
        l_0x100f_83d9:
            ii(0x100f_83d9, 7);  mov(memb[ss, ebp - 132], 0x15);       /* mov byte [ebp-0x84], 0x15 */
        l_0x100f_83e0:
            ii(0x100f_83e0, 6);  mov(al, memb[ss, ebp - 132]);         /* mov al, [ebp-0x84] */
            ii(0x100f_83e6, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x100f_83e9, 5);  jmp(0x100f_8b88, 0x79a); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_83ee:
            ii(0x100f_83ee, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_83f3, 5);  call(0x1007_6574, -0x8_1e84);         /* call 0x10076574 */
            ii(0x100f_83f8, 4);  cmp(memb[ds, eax + 61], 4);           /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100f_83fc, 2);  if(jz(0x100f_840e, 0x10)) goto l_0x100f_840e;/* jz 0x100f840e */
            ii(0x100f_83fe, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8403, 5);  call(0x1007_6574, -0x8_1e94);         /* call 0x10076574 */
            ii(0x100f_8408, 4);  cmp(memb[ds, eax + 61], 0x17);        /* cmp byte [eax+0x3d], 0x17 */
            ii(0x100f_840c, 2);  if(jnz(0x100f_841e, 0x10)) goto l_0x100f_841e;/* jnz 0x100f841e */
        l_0x100f_840e:
            ii(0x100f_840e, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8413, 5);  call(0x1007_6574, -0x8_1ea4);         /* call 0x10076574 */
            ii(0x100f_8418, 4);  test(memb[ds, eax + 19], 1);          /* test byte [eax+0x13], 0x1 */
            ii(0x100f_841c, 2);  if(jnz(0x100f_8420, 2)) goto l_0x100f_8420;/* jnz 0x100f8420 */
        l_0x100f_841e:
            ii(0x100f_841e, 2);  jmp(0x100f_8442, 0x22); goto l_0x100f_8442;/* jmp 0x100f8442 */
        l_0x100f_8420:
            ii(0x100f_8420, 3);  mov(ecx, memd[ss, ebp - 16]);         /* mov ecx, [ebp-0x10] */
            ii(0x100f_8423, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_8427, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100f_842b, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8430, 5);  call(0x1007_6600, -0x8_1e35);         /* call 0x10076600 */
            ii(0x100f_8435, 5);  call(0x100f_70ae, -0x138c);           /* call 0x100f70ae */
            ii(0x100f_843a, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x100f_843d, 5);  jmp(0x100f_8b88, 0x746); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_8442:
            ii(0x100f_8442, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8447, 5);  call(0x1007_6574, -0x8_1ed8);         /* call 0x10076574 */
            ii(0x100f_844c, 4);  cmp(memb[ds, eax + 61], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100f_8450, 2);  if(jnz(0x100f_8474, 0x22)) goto l_0x100f_8474;/* jnz 0x100f8474 */
            ii(0x100f_8452, 3);  mov(ecx, memd[ss, ebp - 16]);         /* mov ecx, [ebp-0x10] */
            ii(0x100f_8455, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_8459, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100f_845d, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8462, 5);  call(0x1007_6600, -0x8_1e67);         /* call 0x10076600 */
            ii(0x100f_8467, 5);  call(0x100f_7312, -0x115a);           /* call 0x100f7312 */
            ii(0x100f_846c, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x100f_846f, 5);  jmp(0x100f_8b88, 0x714); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_8474:
            ii(0x100f_8474, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8479, 5);  call(0x1007_6574, -0x8_1f0a);         /* call 0x10076574 */
            ii(0x100f_847e, 4);  cmp(memb[ds, eax + 62], 1);           /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100f_8482, 6);  if(jnz(0x100f_851e, 0x96)) goto l_0x100f_851e;/* jnz 0x100f851e */
            ii(0x100f_8488, 5);  mov(ecx, 0x40_0000);                  /* mov ecx, 0x400000 */
            ii(0x100f_848d, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_8491, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100f_8495, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_8497, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_849c, 1);  cwde();                               /* cwde */
            ii(0x100f_849d, 5);  call(0x1007_459a, -0x8_3f08);         /* call 0x1007459a */
            ii(0x100f_84a2, 6);  mov(memd[ss, ebp - 136], eax);        /* mov [ebp-0x88], eax */
            ii(0x100f_84a8, 7);  cmp(memd[ss, ebp - 136], 0);          /* cmp dword [ebp-0x88], 0x0 */
            ii(0x100f_84af, 2);  if(jz(0x100f_84be, 0xd)) goto l_0x100f_84be;/* jz 0x100f84be */
            ii(0x100f_84b1, 6);  mov(eax, memd[ss, ebp - 136]);        /* mov eax, [ebp-0x88] */
            ii(0x100f_84b7, 5);  cmp(memw[ds, eax + 8], 0xc);          /* cmp word [eax+0x8], 0xc */
            ii(0x100f_84bc, 2);  if(jnz(0x100f_84c0, 2)) goto l_0x100f_84c0;/* jnz 0x100f84c0 */
        l_0x100f_84be:
            ii(0x100f_84be, 2);  jmp(0x100f_851e, 0x5e); goto l_0x100f_851e;/* jmp 0x100f851e */
        l_0x100f_84c0:
            ii(0x100f_84c0, 6);  mov(eax, memd[ss, ebp - 136]);        /* mov eax, [ebp-0x88] */
            ii(0x100f_84c6, 4);  test(memb[ds, eax + 18], 1);          /* test byte [eax+0x12], 0x1 */
            ii(0x100f_84ca, 2);  if(jz(0x100f_84d9, 0xd)) goto l_0x100f_84d9;/* jz 0x100f84d9 */
            ii(0x100f_84cc, 6);  mov(eax, memd[ss, ebp - 136]);        /* mov eax, [ebp-0x88] */
            ii(0x100f_84d2, 5);  cmp(memw[ds, eax + 8], 0x29);         /* cmp word [eax+0x8], 0x29 */
            ii(0x100f_84d7, 2);  if(jnz(0x100f_84db, 2)) goto l_0x100f_84db;/* jnz 0x100f84db */
        l_0x100f_84d9:
            ii(0x100f_84d9, 2);  jmp(0x100f_84e8, 0xd); goto l_0x100f_84e8;/* jmp 0x100f84e8 */
        l_0x100f_84db:
            ii(0x100f_84db, 6);  mov(eax, memd[ss, ebp - 136]);        /* mov eax, [ebp-0x88] */
            ii(0x100f_84e1, 5);  cmp(memw[ds, eax + 8], 0x2a);         /* cmp word [eax+0x8], 0x2a */
            ii(0x100f_84e6, 2);  if(jnz(0x100f_851e, 0x36)) goto l_0x100f_851e;/* jnz 0x100f851e */
        l_0x100f_84e8:
            ii(0x100f_84e8, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_84ec, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100f_84f0, 6);  mov(eax, memd[ss, ebp - 136]);        /* mov eax, [ebp-0x88] */
            ii(0x100f_84f6, 5);  call(0x100f_7c68, -0x893);            /* call 0x100f7c68 */
            ii(0x100f_84fb, 6);  mov(memb[ss, ebp - 140], al);         /* mov [ebp-0x8c], al */
            ii(0x100f_8501, 7);  cmp(memb[ss, ebp - 140], 0x15);       /* cmp byte [ebp-0x8c], 0x15 */
            ii(0x100f_8508, 2);  if(jnz(0x100f_8510, 6)) goto l_0x100f_8510;/* jnz 0x100f8510 */
            ii(0x100f_850a, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_850e, 2);  if(jnz(0x100f_851e, 0xe)) goto l_0x100f_851e;/* jnz 0x100f851e */
        l_0x100f_8510:
            ii(0x100f_8510, 6);  mov(al, memb[ss, ebp - 140]);         /* mov al, [ebp-0x8c] */
            ii(0x100f_8516, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x100f_8519, 5);  jmp(0x100f_8b88, 0x66a); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_851e:
            ii(0x100f_851e, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8523, 5);  call(0x1007_6574, -0x8_1fb4);         /* call 0x10076574 */
            ii(0x100f_8528, 4);  cmp(memb[ds, eax + 85], 0);           /* cmp byte [eax+0x55], 0x0 */
            ii(0x100f_852c, 6);  if(jz(0x100f_8623, 0xf1)) goto l_0x100f_8623;/* jz 0x100f8623 */
            ii(0x100f_8532, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100f_8535, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_853a, 5);  call(0x1007_6e00, -0x8_173f);         /* call 0x10076e00 */
            ii(0x100f_853f, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_8541, 2);  if(jz(0x100f_854c, 9)) goto l_0x100f_854c;/* jz 0x100f854c */
            ii(0x100f_8543, 4);  mov(memb[ss, ebp - 12], 0x11);        /* mov byte [ebp-0xc], 0x11 */
            ii(0x100f_8547, 5);  jmp(0x100f_8b88, 0x63c); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_854c:
            ii(0x100f_854c, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8551, 5);  call(0x1007_6574, -0x8_1fe2);         /* call 0x10076574 */
            ii(0x100f_8556, 4);  cmp(memb[ds, eax + 80], 0);           /* cmp byte [eax+0x50], 0x0 */
            ii(0x100f_855a, 2);  if(jnz(0x100f_8565, 9)) goto l_0x100f_8565;/* jnz 0x100f8565 */
            ii(0x100f_855c, 4);  mov(memb[ss, ebp - 12], 0x15);        /* mov byte [ebp-0xc], 0x15 */
            ii(0x100f_8560, 5);  jmp(0x100f_8b88, 0x623); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_8565:
            ii(0x100f_8565, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_856a, 5);  call(0x1007_6574, -0x8_1ffb);         /* call 0x10076574 */
            ii(0x100f_856f, 5);  call(0x1007_623c, -0x8_2338);         /* call 0x1007623c */
            ii(0x100f_8574, 3);  mov(ecx, memd[ds, eax + 16]);         /* mov ecx, [eax+0x10] */
            ii(0x100f_8577, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100f_857a, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_857e, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100f_8582, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8587, 5);  call(0x1007_65d0, -0x8_1fbc);         /* call 0x100765d0 */
            ii(0x100f_858c, 5);  call(0x1007_0d68, -0x8_7829);         /* call 0x10070d68 */
            ii(0x100f_8591, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100f_8593, 2);  if(jnz(0x100f_859e, 9)) goto l_0x100f_859e;/* jnz 0x100f859e */
            ii(0x100f_8595, 4);  mov(memb[ss, ebp - 12], 0x15);        /* mov byte [ebp-0xc], 0x15 */
            ii(0x100f_8599, 5);  jmp(0x100f_8b88, 0x5ea); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_859e:
            ii(0x100f_859e, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_85a2, 2);  if(jz(0x100f_85cf, 0x2b)) goto l_0x100f_85cf;/* jz 0x100f85cf */
            ii(0x100f_85a4, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_85a8, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100f_85ac, 6);  lea(eax, memd[ss, ebp - 144]);        /* lea eax, [ebp-0x90] */
            ii(0x100f_85b2, 5);  call(0x1007_6aac, -0x8_1b0b);         /* call 0x10076aac */
            ii(0x100f_85b7, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x100f_85b9, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100f_85bc, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_85c1, 5);  call(0x1008_abbc, -0x6_da0a);         /* call 0x1008abbc */
            ii(0x100f_85c6, 5);  call(0x1007_4b2b, -0x8_3aa0);         /* call 0x10074b2b */
            ii(0x100f_85cb, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_85cd, 2);  if(jz(0x100f_85d1, 2)) goto l_0x100f_85d1;/* jz 0x100f85d1 */
        l_0x100f_85cf:
            ii(0x100f_85cf, 2);  jmp(0x100f_85da, 9); goto l_0x100f_85da;/* jmp 0x100f85da */
        l_0x100f_85d1:
            ii(0x100f_85d1, 4);  mov(memb[ss, ebp - 12], 0x15);        /* mov byte [ebp-0xc], 0x15 */
            ii(0x100f_85d5, 5);  jmp(0x100f_8b88, 0x5ae); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_85da:
            ii(0x100f_85da, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_85dd, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100f_85e0, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100f_85e4, 2);  if(jnz(0x100f_8603, 0x1d)) goto l_0x100f_8603;/* jnz 0x100f8603 */
            ii(0x100f_85e6, 5);  mov(ecx, 0x40_0000);                  /* mov ecx, 0x400000 */
            ii(0x100f_85eb, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_85ef, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100f_85f3, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_85f5, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_85fa, 1);  cwde();                               /* cwde */
            ii(0x100f_85fb, 5);  call(0x1007_459a, -0x8_4066);         /* call 0x1007459a */
            ii(0x100f_8600, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
        l_0x100f_8603:
            ii(0x100f_8603, 5);  mov(ebx, 0x12);                       /* mov ebx, 0x12 */
            ii(0x100f_8608, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x100f_860b, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8610, 5);  call(0x1007_65d0, -0x8_2045);         /* call 0x100765d0 */
            ii(0x100f_8615, 5);  call(0x1012_1078, 0x2_8a5e);          /* call 0x10121078 */
            ii(0x100f_861a, 4);  mov(memb[ss, ebp - 12], 0x12);        /* mov byte [ebp-0xc], 0x12 */
            ii(0x100f_861e, 5);  jmp(0x100f_8b88, 0x565); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_8623:
            ii(0x100f_8623, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8628, 5);  call(0x1007_6574, -0x8_20b9);         /* call 0x10076574 */
            ii(0x100f_862d, 4);  cmp(memb[ds, eax + 86], 0);           /* cmp byte [eax+0x56], 0x0 */
            ii(0x100f_8631, 2);  if(jz(0x100f_8686, 0x53)) goto l_0x100f_8686;/* jz 0x100f8686 */
            ii(0x100f_8633, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100f_8636, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_863b, 5);  call(0x1007_6e00, -0x8_1840);         /* call 0x10076e00 */
            ii(0x100f_8640, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_8642, 2);  if(jz(0x100f_864d, 9)) goto l_0x100f_864d;/* jz 0x100f864d */
            ii(0x100f_8644, 4);  mov(memb[ss, ebp - 12], 0x11);        /* mov byte [ebp-0xc], 0x11 */
            ii(0x100f_8648, 5);  jmp(0x100f_8b88, 0x53b); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_864d:
            ii(0x100f_864d, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_8651, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100f_8655, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_865a, 5);  call(0x1007_6600, -0x8_205f);         /* call 0x10076600 */
            ii(0x100f_865f, 5);  call(0x1007_510b, -0x8_3559);         /* call 0x1007510b */
            ii(0x100f_8664, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100f_8666, 2);  if(jz(0x100f_8671, 9)) goto l_0x100f_8671;/* jz 0x100f8671 */
            ii(0x100f_8668, 7);  mov(memb[ss, ebp - 148], 0x14);       /* mov byte [ebp-0x94], 0x14 */
            ii(0x100f_866f, 2);  jmp(0x100f_8678, 7); goto l_0x100f_8678;/* jmp 0x100f8678 */
        l_0x100f_8671:
            ii(0x100f_8671, 7);  mov(memb[ss, ebp - 148], 0x15);       /* mov byte [ebp-0x94], 0x15 */
        l_0x100f_8678:
            ii(0x100f_8678, 6);  mov(al, memb[ss, ebp - 148]);         /* mov al, [ebp-0x94] */
            ii(0x100f_867e, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x100f_8681, 5);  jmp(0x100f_8b88, 0x502); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_8686:
            ii(0x100f_8686, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_868b, 5);  call(0x1007_6574, -0x8_211c);         /* call 0x10076574 */
            ii(0x100f_8690, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x100f_8693, 5);  and(eax, 0x3c0);                      /* and eax, 0x3c0 */
            ii(0x100f_8698, 6);  mov(memd[ss, ebp - 152], eax);        /* mov [ebp-0x98], eax */
            ii(0x100f_869e, 5);  jmp(0x100f_8b0e, 0x46b); goto l_0x100f_8b0e;/* jmp 0x100f8b0e */
        l_0x100f_86a3:
            ii(0x100f_86a3, 3);  mov(ecx, memd[ss, ebp - 16]);         /* mov ecx, [ebp-0x10] */
            ii(0x100f_86a6, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_86aa, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100f_86ae, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_86b3, 5);  call(0x1007_6600, -0x8_20b8);         /* call 0x10076600 */
            ii(0x100f_86b8, 5);  call(0x100f_750b, -0x11b2);           /* call 0x100f750b */
            ii(0x100f_86bd, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x100f_86c0, 5);  jmp(0x100f_8b88, 0x4c3); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_86c5:
            ii(0x100f_86c5, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_86ca, 5);  call(0x1007_6574, -0x8_215b);         /* call 0x10076574 */
            ii(0x100f_86cf, 4);  cmp(memb[ds, eax + 87], 7);           /* cmp byte [eax+0x57], 0x7 */
            ii(0x100f_86d3, 2);  if(jnz(0x100f_86e5, 0x10)) goto l_0x100f_86e5;/* jnz 0x100f86e5 */
            ii(0x100f_86d5, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_86da, 5);  call(0x1007_6574, -0x8_216b);         /* call 0x10076574 */
            ii(0x100f_86df, 4);  cmp(memb[ds, eax + 62], 1);           /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100f_86e3, 2);  if(jz(0x100f_86e7, 2)) goto l_0x100f_86e7;/* jz 0x100f86e7 */
        l_0x100f_86e5:
            ii(0x100f_86e5, 2);  jmp(0x100f_870c, 0x25); goto l_0x100f_870c;/* jmp 0x100f870c */
        l_0x100f_86e7:
            ii(0x100f_86e7, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_86ec, 5);  call(0x1007_6574, -0x8_217d);         /* call 0x10076574 */
            ii(0x100f_86f1, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100f_86f3, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_86f8, 5);  call(0x1007_6574, -0x8_2189);         /* call 0x10076574 */
            ii(0x100f_86fd, 5);  call(0x1007_623c, -0x8_24c6);         /* call 0x1007623c */
            ii(0x100f_8702, 4);  mov(dx, memw[ds, edx + 82]);          /* mov dx, [edx+0x52] */
            ii(0x100f_8706, 4);  cmp(dx, memw[ds, eax + 25]);          /* cmp dx, [eax+0x19] */
            ii(0x100f_870a, 2);  if(jl(0x100f_8711, 5)) goto l_0x100f_8711;/* jl 0x100f8711 */
        l_0x100f_870c:
            ii(0x100f_870c, 5);  jmp(0x100f_8780, 0x6f); goto l_0x100f_8780;/* jmp 0x100f8780 */
        l_0x100f_8711:
            ii(0x100f_8711, 5);  mov(ecx, 0x100);                      /* mov ecx, 0x100 */
            ii(0x100f_8716, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_8718, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_871d, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x100f_8720, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100f_8724, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_8728, 5);  call(0x1007_388b, -0x8_4ea2);         /* call 0x1007388b */
            ii(0x100f_872d, 5);  mov(memd[ds, 0x101c_3894], eax);      /* mov [0x101c3894], eax */
            ii(0x100f_8732, 7);  cmp(memd[ds, 0x101c_3894], 0);        /* cmp dword [0x101c3894], 0x0 */
            ii(0x100f_8739, 2);  if(jz(0x100f_8746, 0xb)) goto l_0x100f_8746;/* jz 0x100f8746 */
            ii(0x100f_873b, 5);  mov(eax, memd[ds, 0x101c_3894]);      /* mov eax, [0x101c3894] */
            ii(0x100f_8740, 4);  cmp(memb[ds, eax + 61], 0xb);         /* cmp byte [eax+0x3d], 0xb */
            ii(0x100f_8744, 2);  if(jnz(0x100f_8748, 2)) goto l_0x100f_8748;/* jnz 0x100f8748 */
        l_0x100f_8746:
            ii(0x100f_8746, 2);  jmp(0x100f_8753, 0xb); goto l_0x100f_8753;/* jmp 0x100f8753 */
        l_0x100f_8748:
            ii(0x100f_8748, 5);  mov(eax, memd[ds, 0x101c_3894]);      /* mov eax, [0x101c3894] */
            ii(0x100f_874d, 4);  cmp(memb[ds, eax + 61], 4);           /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100f_8751, 2);  if(jnz(0x100f_8755, 2)) goto l_0x100f_8755;/* jnz 0x100f8755 */
        l_0x100f_8753:
            ii(0x100f_8753, 2);  jmp(0x100f_8775, 0x20); goto l_0x100f_8775;/* jmp 0x100f8775 */
        l_0x100f_8755:
            ii(0x100f_8755, 5);  mov(ecx, 0x40);                       /* mov ecx, 0x40 */
            ii(0x100f_875a, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_875c, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_8761, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x100f_8764, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100f_8768, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_876c, 5);  call(0x1007_388b, -0x8_4ee6);         /* call 0x1007388b */
            ii(0x100f_8771, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100f_8773, 2);  if(jz(0x100f_8777, 2)) goto l_0x100f_8777;/* jz 0x100f8777 */
        l_0x100f_8775:
            ii(0x100f_8775, 2);  jmp(0x100f_8780, 9); goto l_0x100f_8780;/* jmp 0x100f8780 */
        l_0x100f_8777:
            ii(0x100f_8777, 4);  mov(memb[ss, ebp - 12], 0x10);        /* mov byte [ebp-0xc], 0x10 */
            ii(0x100f_877b, 5);  jmp(0x100f_8b88, 0x408); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_8780:
            ii(0x100f_8780, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_8784, 2);  if(jz(0x100f_8790, 0xa)) goto l_0x100f_8790;/* jz 0x100f8790 */
            ii(0x100f_8786, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_8789, 5);  cmp(memw[ds, eax + 8], 0x16);         /* cmp word [eax+0x8], 0x16 */
            ii(0x100f_878e, 2);  if(jnz(0x100f_8792, 2)) goto l_0x100f_8792;/* jnz 0x100f8792 */
        l_0x100f_8790:
            ii(0x100f_8790, 2);  jmp(0x100f_879b, 9); goto l_0x100f_879b;/* jmp 0x100f879b */
        l_0x100f_8792:
            ii(0x100f_8792, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_8795, 4);  test(memb[ds, eax + 18], 1);          /* test byte [eax+0x12], 0x1 */
            ii(0x100f_8799, 2);  if(jz(0x100f_879d, 2)) goto l_0x100f_879d;/* jz 0x100f879d */
        l_0x100f_879b:
            ii(0x100f_879b, 2);  jmp(0x100f_87a6, 9); goto l_0x100f_87a6;/* jmp 0x100f87a6 */
        l_0x100f_879d:
            ii(0x100f_879d, 4);  mov(memb[ss, ebp - 12], 0x11);        /* mov byte [ebp-0xc], 0x11 */
            ii(0x100f_87a1, 5);  jmp(0x100f_8b88, 0x3e2); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_87a6:
            ii(0x100f_87a6, 7);  cmp(memb[ds, 0x101c_3918], 0);        /* cmp byte [0x101c3918], 0x0 */
            ii(0x100f_87ad, 2);  if(jz(0x100f_87b8, 9)) goto l_0x100f_87b8;/* jz 0x100f87b8 */
            ii(0x100f_87af, 7);  mov(memb[ss, ebp - 156], 0x16);       /* mov byte [ebp-0x9c], 0x16 */
            ii(0x100f_87b6, 2);  jmp(0x100f_87bf, 7); goto l_0x100f_87bf;/* jmp 0x100f87bf */
        l_0x100f_87b8:
            ii(0x100f_87b8, 7);  mov(memb[ss, ebp - 156], 0x14);       /* mov byte [ebp-0x9c], 0x14 */
        l_0x100f_87bf:
            ii(0x100f_87bf, 6);  mov(al, memb[ss, ebp - 156]);         /* mov al, [ebp-0x9c] */
            ii(0x100f_87c5, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x100f_87c8, 5);  jmp(0x100f_8b88, 0x3bb); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_87cd:
            ii(0x100f_87cd, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_87d2, 5);  call(0x1007_6574, -0x8_2263);         /* call 0x10076574 */
            ii(0x100f_87d7, 4);  cmp(memb[ds, eax + 87], 7);           /* cmp byte [eax+0x57], 0x7 */
            ii(0x100f_87db, 2);  if(jnz(0x100f_8802, 0x25)) goto l_0x100f_8802;/* jnz 0x100f8802 */
            ii(0x100f_87dd, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_87e2, 5);  call(0x1007_6574, -0x8_2273);         /* call 0x10076574 */
            ii(0x100f_87e7, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100f_87e9, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_87ee, 5);  call(0x1007_6574, -0x8_227f);         /* call 0x10076574 */
            ii(0x100f_87f3, 5);  call(0x1007_623c, -0x8_25bc);         /* call 0x1007623c */
            ii(0x100f_87f8, 4);  mov(dx, memw[ds, edx + 82]);          /* mov dx, [edx+0x52] */
            ii(0x100f_87fc, 4);  cmp(dx, memw[ds, eax + 25]);          /* cmp dx, [eax+0x19] */
            ii(0x100f_8800, 2);  if(jl(0x100f_8807, 5)) goto l_0x100f_8807;/* jl 0x100f8807 */
        l_0x100f_8802:
            ii(0x100f_8802, 5);  jmp(0x100f_89c4, 0x1bd); goto l_0x100f_89c4;/* jmp 0x100f89c4 */
        l_0x100f_8807:
            ii(0x100f_8807, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_880c, 5);  call(0x1007_6574, -0x8_229d);         /* call 0x10076574 */
            ii(0x100f_8811, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x100f_8815, 6);  mov(memd[ss, ebp - 160], eax);        /* mov [ebp-0xa0], eax */
            ii(0x100f_881b, 5);  jmp(0x100f_8974, 0x154); goto l_0x100f_8974;/* jmp 0x100f8974 */
        l_0x100f_8820:
            ii(0x100f_8820, 5);  mov(ecx, 0x100);                      /* mov ecx, 0x100 */
            ii(0x100f_8825, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_8827, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_882c, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x100f_882f, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100f_8833, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_8837, 5);  call(0x1007_388b, -0x8_4fb1);         /* call 0x1007388b */
            ii(0x100f_883c, 5);  mov(memd[ds, 0x101c_3894], eax);      /* mov [0x101c3894], eax */
            ii(0x100f_8841, 7);  cmp(memd[ds, 0x101c_3894], 0);        /* cmp dword [0x101c3894], 0x0 */
            ii(0x100f_8848, 2);  if(jz(0x100f_8864, 0x1a)) goto l_0x100f_8864;/* jz 0x100f8864 */
            ii(0x100f_884a, 5);  mov(eax, memd[ds, 0x101c_3894]);      /* mov eax, [0x101c3894] */
            ii(0x100f_884f, 5);  cmp(memw[ds, eax + 8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x100f_8854, 2);  if(jz(0x100f_8862, 0xc)) goto l_0x100f_8862;/* jz 0x100f8862 */
            ii(0x100f_8856, 5);  mov(eax, memd[ds, 0x101c_3894]);      /* mov eax, [0x101c3894] */
            ii(0x100f_885b, 5);  cmp(memw[ds, eax + 8], 0x43);         /* cmp word [eax+0x8], 0x43 */
            ii(0x100f_8860, 2);  if(jnz(0x100f_8864, 2)) goto l_0x100f_8864;/* jnz 0x100f8864 */
        l_0x100f_8862:
            ii(0x100f_8862, 2);  jmp(0x100f_8866, 2); goto l_0x100f_8866;/* jmp 0x100f8866 */
        l_0x100f_8864:
            ii(0x100f_8864, 2);  jmp(0x100f_886f, 9); goto l_0x100f_886f;/* jmp 0x100f886f */
        l_0x100f_8866:
            ii(0x100f_8866, 4);  mov(memb[ss, ebp - 12], 0x10);        /* mov byte [ebp-0xc], 0x10 */
            ii(0x100f_886a, 5);  jmp(0x100f_8b88, 0x319); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_886f:
            ii(0x100f_886f, 5);  jmp(0x100f_89c4, 0x150); goto l_0x100f_89c4;/* jmp 0x100f89c4 */
        l_0x100f_8874:
            ii(0x100f_8874, 5);  mov(ecx, 0x100);                      /* mov ecx, 0x100 */
            ii(0x100f_8879, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_887b, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_8880, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x100f_8883, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100f_8887, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_888b, 5);  call(0x1007_388b, -0x8_5005);         /* call 0x1007388b */
            ii(0x100f_8890, 5);  mov(memd[ds, 0x101c_3894], eax);      /* mov [0x101c3894], eax */
            ii(0x100f_8895, 7);  cmp(memd[ds, 0x101c_3894], 0);        /* cmp dword [0x101c3894], 0x0 */
            ii(0x100f_889c, 2);  if(jz(0x100f_88ac, 0xe)) goto l_0x100f_88ac;/* jz 0x100f88ac */
            ii(0x100f_889e, 5);  mov(eax, memd[ds, 0x101c_3894]);      /* mov eax, [0x101c3894] */
            ii(0x100f_88a3, 5);  call(0x100a_2edb, -0x5_59cd);         /* call 0x100a2edb */
            ii(0x100f_88a8, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_88aa, 2);  if(jnz(0x100f_88ae, 2)) goto l_0x100f_88ae;/* jnz 0x100f88ae */
        l_0x100f_88ac:
            ii(0x100f_88ac, 2);  jmp(0x100f_88ba, 0xc); goto l_0x100f_88ba;/* jmp 0x100f88ba */
        l_0x100f_88ae:
            ii(0x100f_88ae, 5);  mov(eax, memd[ds, 0x101c_3894]);      /* mov eax, [0x101c3894] */
            ii(0x100f_88b3, 5);  cmp(memw[ds, eax + 8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x100f_88b8, 2);  if(jnz(0x100f_88bc, 2)) goto l_0x100f_88bc;/* jnz 0x100f88bc */
        l_0x100f_88ba:
            ii(0x100f_88ba, 2);  jmp(0x100f_88c8, 0xc); goto l_0x100f_88c8;/* jmp 0x100f88c8 */
        l_0x100f_88bc:
            ii(0x100f_88bc, 5);  mov(eax, memd[ds, 0x101c_3894]);      /* mov eax, [0x101c3894] */
            ii(0x100f_88c1, 5);  cmp(memw[ds, eax + 8], 0x43);         /* cmp word [eax+0x8], 0x43 */
            ii(0x100f_88c6, 2);  if(jnz(0x100f_88ca, 2)) goto l_0x100f_88ca;/* jnz 0x100f88ca */
        l_0x100f_88c8:
            ii(0x100f_88c8, 2);  jmp(0x100f_88d3, 9); goto l_0x100f_88d3;/* jmp 0x100f88d3 */
        l_0x100f_88ca:
            ii(0x100f_88ca, 4);  mov(memb[ss, ebp - 12], 0x10);        /* mov byte [ebp-0xc], 0x10 */
            ii(0x100f_88ce, 5);  jmp(0x100f_8b88, 0x2b5); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_88d3:
            ii(0x100f_88d3, 5);  jmp(0x100f_89c4, 0xec); goto l_0x100f_89c4;/* jmp 0x100f89c4 */
        l_0x100f_88d8:
            ii(0x100f_88d8, 5);  mov(ecx, 0x80);                       /* mov ecx, 0x80 */
            ii(0x100f_88dd, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_88df, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_88e4, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x100f_88e7, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100f_88eb, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_88ef, 5);  call(0x1007_388b, -0x8_5069);         /* call 0x1007388b */
            ii(0x100f_88f4, 5);  mov(memd[ds, 0x101c_3894], eax);      /* mov [0x101c3894], eax */
            ii(0x100f_88f9, 7);  cmp(memd[ds, 0x101c_3894], 0);        /* cmp dword [0x101c3894], 0x0 */
            ii(0x100f_8900, 2);  if(jz(0x100f_890d, 0xb)) goto l_0x100f_890d;/* jz 0x100f890d */
            ii(0x100f_8902, 5);  mov(eax, memd[ds, 0x101c_3894]);      /* mov eax, [0x101c3894] */
            ii(0x100f_8907, 4);  test(memb[ds, eax + 19], 1);          /* test byte [eax+0x13], 0x1 */
            ii(0x100f_890b, 2);  if(jz(0x100f_890f, 2)) goto l_0x100f_890f;/* jz 0x100f890f */
        l_0x100f_890d:
            ii(0x100f_890d, 2);  jmp(0x100f_891d, 0xe); goto l_0x100f_891d;/* jmp 0x100f891d */
        l_0x100f_890f:
            ii(0x100f_890f, 5);  mov(eax, memd[ds, 0x101c_3894]);      /* mov eax, [0x101c3894] */
            ii(0x100f_8914, 5);  call(0x100a_2edb, -0x5_5a3e);         /* call 0x100a2edb */
            ii(0x100f_8919, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_891b, 2);  if(jnz(0x100f_891f, 2)) goto l_0x100f_891f;/* jnz 0x100f891f */
        l_0x100f_891d:
            ii(0x100f_891d, 2);  jmp(0x100f_8928, 9); goto l_0x100f_8928;/* jmp 0x100f8928 */
        l_0x100f_891f:
            ii(0x100f_891f, 4);  mov(memb[ss, ebp - 12], 0x10);        /* mov byte [ebp-0xc], 0x10 */
            ii(0x100f_8923, 5);  jmp(0x100f_8b88, 0x260); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_8928:
            ii(0x100f_8928, 5);  jmp(0x100f_89c4, 0x97); goto l_0x100f_89c4;/* jmp 0x100f89c4 */
        l_0x100f_892d:
            ii(0x100f_892d, 5);  mov(ecx, 0x40);                       /* mov ecx, 0x40 */
            ii(0x100f_8932, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_8934, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_8939, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x100f_893c, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100f_8940, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_8944, 5);  call(0x1007_388b, -0x8_50be);         /* call 0x1007388b */
            ii(0x100f_8949, 5);  mov(memd[ds, 0x101c_3894], eax);      /* mov [0x101c3894], eax */
            ii(0x100f_894e, 7);  cmp(memd[ds, 0x101c_3894], 0);        /* cmp dword [0x101c3894], 0x0 */
            ii(0x100f_8955, 2);  if(jz(0x100f_8965, 0xe)) goto l_0x100f_8965;/* jz 0x100f8965 */
            ii(0x100f_8957, 5);  mov(eax, memd[ds, 0x101c_3894]);      /* mov eax, [0x101c3894] */
            ii(0x100f_895c, 5);  call(0x100a_2edb, -0x5_5a86);         /* call 0x100a2edb */
            ii(0x100f_8961, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_8963, 2);  if(jnz(0x100f_8967, 2)) goto l_0x100f_8967;/* jnz 0x100f8967 */
        l_0x100f_8965:
            ii(0x100f_8965, 2);  jmp(0x100f_8970, 9); goto l_0x100f_8970;/* jmp 0x100f8970 */
        l_0x100f_8967:
            ii(0x100f_8967, 4);  mov(memb[ss, ebp - 12], 0x10);        /* mov byte [ebp-0xc], 0x10 */
            ii(0x100f_896b, 5);  jmp(0x100f_8b88, 0x218); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_8970:
            ii(0x100f_8970, 2);  jmp(0x100f_89c4, 0x52); goto l_0x100f_89c4;/* jmp 0x100f89c4 */
        l_0x100f_8972:
            ii(0x100f_8972, 2);  jmp(0x100f_89c4, 0x50); goto l_0x100f_89c4;/* jmp 0x100f89c4 */
        l_0x100f_8974:
            ii(0x100f_8974, 6);  mov(eax, memd[ss, ebp - 160]);        /* mov eax, [ebp-0xa0] */
            ii(0x100f_897a, 6);  mov(memd[ss, ebp - 164], eax);        /* mov [ebp-0xa4], eax */
            ii(0x100f_8980, 8);  cmp(memw[ss, ebp - 164], 9);          /* cmp word [ebp-0xa4], 0x9 */
            ii(0x100f_8988, 2);  if(jb(0x100f_89b4, 0x2a)) goto l_0x100f_89b4;/* jb 0x100f89b4 */
            ii(0x100f_898a, 8);  cmp(memw[ss, ebp - 164], 9);          /* cmp word [ebp-0xa4], 0x9 */
            ii(0x100f_8992, 6);  if(jbe(0x100f_8874, -0x124)) goto l_0x100f_8874;/* jbe 0x100f8874 */
            ii(0x100f_8998, 8);  cmp(memw[ss, ebp - 164], 0xa);        /* cmp word [ebp-0xa4], 0xa */
            ii(0x100f_89a0, 2);  if(jbe(0x100f_892d, -0x75)) goto l_0x100f_892d;/* jbe 0x100f892d */
            ii(0x100f_89a2, 8);  cmp(memw[ss, ebp - 164], 0xb);        /* cmp word [ebp-0xa4], 0xb */
            ii(0x100f_89aa, 6);  if(jz(0x100f_88d8, -0xd8)) goto l_0x100f_88d8;/* jz 0x100f88d8 */
            ii(0x100f_89b0, 2);  jmp(0x100f_8972, -0x40); goto l_0x100f_8972;/* jmp 0x100f8972 */
        //  ii(0x100f_89b2, 2);  Недостижимый код.
        l_0x100f_89b4:
            ii(0x100f_89b4, 8);  cmp(memw[ss, ebp - 164], 3);          /* cmp word [ebp-0xa4], 0x3 */
            ii(0x100f_89bc, 6);  if(jz(0x100f_8820, -0x1a2)) goto l_0x100f_8820;/* jz 0x100f8820 */
            ii(0x100f_89c2, 2);  jmp(0x100f_8972, -0x52); goto l_0x100f_8972;/* jmp 0x100f8972 */
        l_0x100f_89c4:
            ii(0x100f_89c4, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_89c9, 5);  call(0x1007_6574, -0x8_245a);         /* call 0x10076574 */
            ii(0x100f_89ce, 4);  cmp(memb[ds, eax + 87], 0);           /* cmp byte [eax+0x57], 0x0 */
            ii(0x100f_89d2, 6);  if(jz(0x100f_8ae5, 0x10d)) goto l_0x100f_8ae5;/* jz 0x100f8ae5 */
            ii(0x100f_89d8, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_89da, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_89df, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x100f_89e2, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100f_89e6, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_89ea, 5);  call(0x1007_3aa6, -0x8_4f49);         /* call 0x10073aa6 */
            ii(0x100f_89ef, 5);  mov(memd[ds, 0x101c_3894], eax);      /* mov [0x101c3894], eax */
            ii(0x100f_89f4, 7);  cmp(memd[ds, 0x101c_3894], 0);        /* cmp dword [0x101c3894], 0x0 */
            ii(0x100f_89fb, 2);  if(jz(0x100f_8a17, 0x1a)) goto l_0x100f_8a17;/* jz 0x100f8a17 */
            ii(0x100f_89fd, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8a02, 5);  call(0x1007_6600, -0x8_2407);         /* call 0x10076600 */
            ii(0x100f_8a07, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100f_8a09, 5);  mov(eax, memd[ds, 0x101c_3894]);      /* mov eax, [0x101c3894] */
            ii(0x100f_8a0e, 5);  call(0x100f_7844, -0x11cf);           /* call 0x100f7844 */
            ii(0x100f_8a13, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100f_8a15, 2);  if(jnz(0x100f_8a1c, 5)) goto l_0x100f_8a1c;/* jnz 0x100f8a1c */
        l_0x100f_8a17:
            ii(0x100f_8a17, 5);  jmp(0x100f_8ae5, 0xc9); goto l_0x100f_8ae5;/* jmp 0x100f8ae5 */
        l_0x100f_8a1c:
            ii(0x100f_8a1c, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8a21, 5);  call(0x1007_6574, -0x8_24b2);         /* call 0x10076574 */
            ii(0x100f_8a26, 3);  mov(al, memb[ds, eax + 87]);          /* mov al, [eax+0x57] */
            ii(0x100f_8a29, 6);  mov(memb[ss, ebp - 168], al);         /* mov [ebp-0xa8], al */
            ii(0x100f_8a2f, 5);  jmp(0x100f_8ab6, 0x82); goto l_0x100f_8ab6;/* jmp 0x100f8ab6 */
        l_0x100f_8a34:
            ii(0x100f_8a34, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_8a39, 5);  call(0x1007_6574, -0x8_24ca);         /* call 0x10076574 */
            ii(0x100f_8a3e, 3);  mov(edx, memd[ds, eax + 6]);          /* mov edx, [eax+0x6] */
            ii(0x100f_8a41, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100f_8a44, 3);  imul(edx, edx, 0x33);                 /* imul edx, edx, 0x33 */
            ii(0x100f_8a47, 5);  mov(eax, memd[ds, 0x101c_3894]);      /* mov eax, [0x101c3894] */
            ii(0x100f_8a4c, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100f_8a4f, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100f_8a52, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x100f_8a55, 6);  mov(dl, memb[ds, edx + 0x101c_81d5]); /* mov dl, [edx+0x101c81d5] */
            ii(0x100f_8a5b, 6);  cmp(dl, memb[ds, eax + 0x101c_81d5]); /* cmp dl, [eax+0x101c81d5] */
            ii(0x100f_8a61, 2);  if(jnz(0x100f_8a6e, 0xb)) goto l_0x100f_8a6e;/* jnz 0x100f8a6e */
            ii(0x100f_8a63, 5);  mov(eax, memd[ds, 0x101c_3894]);      /* mov eax, [0x101c3894] */
            ii(0x100f_8a68, 4);  cmp(memb[ds, eax + 61], 0xb);         /* cmp byte [eax+0x3d], 0xb */
            ii(0x100f_8a6c, 2);  if(jnz(0x100f_8a70, 2)) goto l_0x100f_8a70;/* jnz 0x100f8a70 */
        l_0x100f_8a6e:
            ii(0x100f_8a6e, 2);  jmp(0x100f_8a7b, 0xb); goto l_0x100f_8a7b;/* jmp 0x100f8a7b */
        l_0x100f_8a70:
            ii(0x100f_8a70, 5);  mov(eax, memd[ds, 0x101c_3894]);      /* mov eax, [0x101c3894] */
            ii(0x100f_8a75, 4);  cmp(memb[ds, eax + 61], 4);           /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100f_8a79, 2);  if(jnz(0x100f_8a7d, 2)) goto l_0x100f_8a7d;/* jnz 0x100f8a7d */
        l_0x100f_8a7b:
            ii(0x100f_8a7b, 2);  jmp(0x100f_8a86, 9); goto l_0x100f_8a86;/* jmp 0x100f8a86 */
        l_0x100f_8a7d:
            ii(0x100f_8a7d, 4);  mov(memb[ss, ebp - 12], 0xd);         /* mov byte [ebp-0xc], 0xd */
            ii(0x100f_8a81, 5);  jmp(0x100f_8b88, 0x102); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_8a86:
            ii(0x100f_8a86, 2);  jmp(0x100f_8ae5, 0x5d); goto l_0x100f_8ae5;/* jmp 0x100f8ae5 */
        l_0x100f_8a88:
            ii(0x100f_8a88, 5);  mov(eax, memd[ds, 0x101c_3894]);      /* mov eax, [0x101c3894] */
            ii(0x100f_8a8d, 5);  call(0x1007_623c, -0x8_2856);         /* call 0x1007623c */
            ii(0x100f_8a92, 3);  mov(edx, memd[ds, eax + 25]);         /* mov edx, [eax+0x19] */
            ii(0x100f_8a95, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100f_8a98, 5);  mov(eax, memd[ds, 0x101c_3894]);      /* mov eax, [0x101c3894] */
            ii(0x100f_8a9d, 3);  mov(al, memb[ds, eax + 84]);          /* mov al, [eax+0x54] */
            ii(0x100f_8aa0, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100f_8aa5, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x100f_8aa7, 2);  if(jge(0x100f_8ab2, 9)) goto l_0x100f_8ab2;/* jge 0x100f8ab2 */
            ii(0x100f_8aa9, 4);  mov(memb[ss, ebp - 12], 0xf);         /* mov byte [ebp-0xc], 0xf */
            ii(0x100f_8aad, 5);  jmp(0x100f_8b88, 0xd6); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_8ab2:
            ii(0x100f_8ab2, 2);  jmp(0x100f_8ae5, 0x31); goto l_0x100f_8ae5;/* jmp 0x100f8ae5 */
        l_0x100f_8ab4:
            ii(0x100f_8ab4, 2);  jmp(0x100f_8ae5, 0x2f); goto l_0x100f_8ae5;/* jmp 0x100f8ae5 */
        l_0x100f_8ab6:
            ii(0x100f_8ab6, 6);  mov(al, memb[ss, ebp - 168]);         /* mov al, [ebp-0xa8] */
            ii(0x100f_8abc, 6);  mov(memb[ss, ebp - 172], al);         /* mov [ebp-0xac], al */
            ii(0x100f_8ac2, 7);  cmp(memb[ss, ebp - 172], 3);          /* cmp byte [ebp-0xac], 0x3 */
            ii(0x100f_8ac9, 2);  if(jb(0x100f_8ae3, 0x18)) goto l_0x100f_8ae3;/* jb 0x100f8ae3 */
            ii(0x100f_8acb, 7);  cmp(memb[ss, ebp - 172], 3);          /* cmp byte [ebp-0xac], 0x3 */
            ii(0x100f_8ad2, 6);  if(jbe(0x100f_8a34, -0xa4)) goto l_0x100f_8a34;/* jbe 0x100f8a34 */
            ii(0x100f_8ad8, 7);  cmp(memb[ss, ebp - 172], 6);          /* cmp byte [ebp-0xac], 0x6 */
            ii(0x100f_8adf, 2);  if(jz(0x100f_8a88, -0x59)) goto l_0x100f_8a88;/* jz 0x100f8a88 */
            ii(0x100f_8ae1, 2);  jmp(0x100f_8ab4, -0x2f); goto l_0x100f_8ab4;/* jmp 0x100f8ab4 */
        l_0x100f_8ae3:
            ii(0x100f_8ae3, 2);  jmp(0x100f_8ab4, -0x31); goto l_0x100f_8ab4;/* jmp 0x100f8ab4 */
        l_0x100f_8ae5:
            ii(0x100f_8ae5, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_8ae9, 2);  if(jz(0x100f_8af4, 9)) goto l_0x100f_8af4;/* jz 0x100f8af4 */
            ii(0x100f_8aeb, 7);  mov(memb[ss, ebp - 176], 0x11);       /* mov byte [ebp-0xb0], 0x11 */
            ii(0x100f_8af2, 2);  jmp(0x100f_8afb, 7); goto l_0x100f_8afb;/* jmp 0x100f8afb */
        l_0x100f_8af4:
            ii(0x100f_8af4, 7);  mov(memb[ss, ebp - 176], 0x15);       /* mov byte [ebp-0xb0], 0x15 */
        l_0x100f_8afb:
            ii(0x100f_8afb, 6);  mov(al, memb[ss, ebp - 176]);         /* mov al, [ebp-0xb0] */
            ii(0x100f_8b01, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x100f_8b04, 5);  jmp(0x100f_8b88, 0x7f); goto l_0x100f_8b88;/* jmp 0x100f8b88 */
        l_0x100f_8b09:
            ii(0x100f_8b09, 5);  jmp(0x100f_8b84, 0x76); goto l_0x100f_8b84;/* jmp 0x100f8b84 */
        l_0x100f_8b0e:
            ii(0x100f_8b0e, 10);  cmp(memd[ss, ebp - 152], 0x100);     /* cmp dword [ebp-0x98], 0x100 */
            ii(0x100f_8b18, 2);  if(jb(0x100f_8b5a, 0x40)) goto l_0x100f_8b5a;/* jb 0x100f8b5a */
            ii(0x100f_8b1a, 10);  cmp(memd[ss, ebp - 152], 0x100);     /* cmp dword [ebp-0x98], 0x100 */
            ii(0x100f_8b24, 6);  if(jbe(0x100f_86a3, -0x487)) goto l_0x100f_86a3;/* jbe 0x100f86a3 */
            ii(0x100f_8b2a, 10);  cmp(memd[ss, ebp - 152], 0x180);     /* cmp dword [ebp-0x98], 0x180 */
            ii(0x100f_8b34, 2);  if(jb(0x100f_8b58, 0x22)) goto l_0x100f_8b58;/* jb 0x100f8b58 */
            ii(0x100f_8b36, 10);  cmp(memd[ss, ebp - 152], 0x180);     /* cmp dword [ebp-0x98], 0x180 */
            ii(0x100f_8b40, 6);  if(jbe(0x100f_86a3, -0x4a3)) goto l_0x100f_86a3;/* jbe 0x100f86a3 */
            ii(0x100f_8b46, 10);  cmp(memd[ss, ebp - 152], 0x200);     /* cmp dword [ebp-0x98], 0x200 */
            ii(0x100f_8b50, 6);  if(jz(0x100f_87cd, -0x389)) goto l_0x100f_87cd;/* jz 0x100f87cd */
            ii(0x100f_8b56, 2);  jmp(0x100f_8b09, -0x4f); goto l_0x100f_8b09;/* jmp 0x100f8b09 */
        l_0x100f_8b58:
            ii(0x100f_8b58, 2);  jmp(0x100f_8b09, -0x51); goto l_0x100f_8b09;/* jmp 0x100f8b09 */
        l_0x100f_8b5a:
            ii(0x100f_8b5a, 7);  cmp(memd[ss, ebp - 152], 0x40);       /* cmp dword [ebp-0x98], 0x40 */
            ii(0x100f_8b61, 2);  if(jb(0x100f_8b82, 0x1f)) goto l_0x100f_8b82;/* jb 0x100f8b82 */
            ii(0x100f_8b63, 7);  cmp(memd[ss, ebp - 152], 0x40);       /* cmp dword [ebp-0x98], 0x40 */
            ii(0x100f_8b6a, 6);  if(jbe(0x100f_86c5, -0x4ab)) goto l_0x100f_86c5;/* jbe 0x100f86c5 */
            ii(0x100f_8b70, 10);  cmp(memd[ss, ebp - 152], 0x80);      /* cmp dword [ebp-0x98], 0x80 */
            ii(0x100f_8b7a, 6);  if(jz(0x100f_86a3, -0x4dd)) goto l_0x100f_86a3;/* jz 0x100f86a3 */
            ii(0x100f_8b80, 2);  jmp(0x100f_8b09, -0x79); goto l_0x100f_8b09;/* jmp 0x100f8b09 */
        l_0x100f_8b82:
            ii(0x100f_8b82, 2);  jmp(0x100f_8b09, -0x7b); goto l_0x100f_8b09;/* jmp 0x100f8b09 */
        l_0x100f_8b84:
            ii(0x100f_8b84, 4);  mov(memb[ss, ebp - 12], 0x15);        /* mov byte [ebp-0xc], 0x15 */
        l_0x100f_8b88:
            ii(0x100f_8b88, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100f_8b8b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_8b8d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_8b8e, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_8b8f, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_8b90, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_8b91, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_8b92, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_3c32-9043b9f9")]
        public void Method_100f_3c32()
        {
            ii(0x100f_3c32, 5);  push(0x17c);                          /* push 0x17c */
            ii(0x100f_3c37, 5);  call(Definitions.sys_check_available_stack_size, 0x7_2116);/* call 0x10165d52 */
            ii(0x100f_3c3c, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_3c3d, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_3c3e, 1);  push(esi);                            /* push esi */
            ii(0x100f_3c3f, 1);  push(edi);                            /* push edi */
            ii(0x100f_3c40, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_3c41, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_3c43, 6);  sub(esp, 0x158);                      /* sub esp, 0x158 */
            ii(0x100f_3c49, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_3c4c, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x100f_3c4f, 7);  mov(memd[ss, ebp - 16], 0xffff_ffff); /* mov dword [ebp-0x10], 0xffffffff */
            ii(0x100f_3c56, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100f_3c59, 5);  mov(eax, 0x101c_38b4);                /* mov eax, 0x101c38b4 */
            ii(0x100f_3c5e, 5);  call(0x1007_6630, -0x7_d633);         /* call 0x10076630 */
            ii(0x100f_3c63, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_3c66, 4);  mov(ax, memw[ds, eax + 26]);          /* mov ax, [eax+0x1a] */
            ii(0x100f_3c6a, 6);  mov(memw[ds, 0x101c_38b8], ax);       /* mov [0x101c38b8], ax */
            ii(0x100f_3c70, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_3c73, 4);  mov(ax, memw[ds, eax + 28]);          /* mov ax, [eax+0x1c] */
            ii(0x100f_3c77, 6);  mov(memw[ds, 0x101c_38ba], ax);       /* mov [0x101c38ba], ax */
            ii(0x100f_3c7d, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x100f_3c80, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x100f_3c83, 5);  jmp(0x100f_3ec0, 0x238); goto l_0x100f_3ec0;/* jmp 0x100f3ec0 */
        l_0x100f_3c88:
            ii(0x100f_3c88, 3);  lea(edi, memd[ss, ebp - 28]);         /* lea edi, [ebp-0x1c] */
            ii(0x100f_3c8b, 5);  mov(esi, 0x101b_8ab8);                /* mov esi, 0x101b8ab8 */
            ii(0x100f_3c90, 1);  movsd();                              /* movsd */
            ii(0x100f_3c91, 1);  movsd();                              /* movsd */
            ii(0x100f_3c92, 1);  movsd();                              /* movsd */
            ii(0x100f_3c93, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_3c96, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100f_3c99, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100f_3c9c, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x100f_3c9f, 6);  push(memd[ds, eax + 0x101c_81d7]);    /* push dword [eax+0x101c81d7] */
            ii(0x100f_3ca5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_3ca8, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100f_3cab, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100f_3cae, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x100f_3cb1, 6);  mov(eax, memd[ds, eax + 0x101c_81d3]);/* mov eax, [eax+0x101c81d3] */
            ii(0x100f_3cb7, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x100f_3cba, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100f_3cbd, 4);  push(memd[ds, eax + ebp - 28]);       /* push dword [eax+ebp-0x1c] */
            ii(0x100f_3cc1, 6);  lea(eax, memd[ss, ebp - 328]);        /* lea eax, [ebp-0x148] */
            ii(0x100f_3cc7, 1);  push(eax);                            /* push eax */
            ii(0x100f_3cc8, 5);  call(Definitions.sys_sprintf, 0x7_2234);/* call 0x10165f01 */
            ii(0x100f_3ccd, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x100f_3cd0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_3cd3, 5);  call(0x1010_1103, 0xd42b);            /* call 0x10101103 */
            ii(0x100f_3cd8, 3);  test(ax, ax);                         /* test ax, ax */
            ii(0x100f_3cdb, 2);  if(jnz(0x100f_3cee, 0x11)) goto l_0x100f_3cee;/* jnz 0x100f3cee */
            ii(0x100f_3cdd, 5);  mov(eax, memd[ds, 0x101c_3884]);      /* mov eax, [0x101c3884] */
            ii(0x100f_3ce2, 5);  call(0x1014_85ad, 0x5_48c6);          /* call 0x101485ad */
            ii(0x100f_3ce7, 5);  cmp(eax, 0x1388);                     /* cmp eax, 0x1388 */
            ii(0x100f_3cec, 2);  if(ja(0x100f_3cf0, 2)) goto l_0x100f_3cf0;/* ja 0x100f3cf0 */
        l_0x100f_3cee:
            ii(0x100f_3cee, 2);  jmp(0x100f_3d01, 0x11); goto l_0x100f_3d01;/* jmp 0x100f3d01 */
        l_0x100f_3cf0:
            ii(0x100f_3cf0, 7);  mov(memd[ss, ebp - 16], 0x40a);       /* mov dword [ebp-0x10], 0x40a */
            ii(0x100f_3cf7, 10);  mov(memd[ss, ebp - 332], 0x40d);     /* mov dword [ebp-0x14c], 0x40d */
        l_0x100f_3d01:
            ii(0x100f_3d01, 5);  call(0x1014_82f4, 0x5_45ee);          /* call 0x101482f4 */
            ii(0x100f_3d06, 5);  mov(memd[ds, 0x101c_3884], eax);      /* mov [0x101c3884], eax */
            ii(0x100f_3d0b, 5);  jmp(0x100f_3ee4, 0x1d4); goto l_0x100f_3ee4;/* jmp 0x100f3ee4 */
        l_0x100f_3d10:
            ii(0x100f_3d10, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_3d13, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100f_3d16, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100f_3d19, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x100f_3d1c, 6);  push(memd[ds, eax + 0x101c_81d7]);    /* push dword [eax+0x101c81d7] */
            ii(0x100f_3d22, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_3d25, 4);  cmp(memb[ds, eax + 77], 0);           /* cmp byte [eax+0x4d], 0x0 */
            ii(0x100f_3d29, 2);  if(jz(0x100f_3d37, 0xc)) goto l_0x100f_3d37;/* jz 0x100f3d37 */
            ii(0x100f_3d2b, 10);  mov(memd[ss, ebp - 336], StringDefinitions.SUnderAttack);/* mov dword [ebp-0x150], 0x101a2484 */
            ii(0x100f_3d35, 2);  jmp(0x100f_3d41, 0xa); goto l_0x100f_3d41;/* jmp 0x100f3d41 */
        l_0x100f_3d37:
            ii(0x100f_3d37, 10);  mov(memd[ss, ebp - 336], StringDefinitions.SHasBeenDestroyed);/* mov dword [ebp-0x150], 0x101a2495 */
        l_0x100f_3d41:
            ii(0x100f_3d41, 6);  push(memd[ss, ebp - 336]);            /* push dword [ebp-0x150] */
            ii(0x100f_3d47, 6);  lea(eax, memd[ss, ebp - 328]);        /* lea eax, [ebp-0x148] */
            ii(0x100f_3d4d, 1);  push(eax);                            /* push eax */
            ii(0x100f_3d4e, 5);  call(Definitions.sys_sprintf, 0x7_21ae);/* call 0x10165f01 */
            ii(0x100f_3d53, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x100f_3d56, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_3d59, 3);  mov(al, memb[ds, eax + 77]);          /* mov al, [eax+0x4d] */
            ii(0x100f_3d5c, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100f_3d61, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100f_3d63, 2);  if(jnz(0x100f_3d91, 0x2c)) goto l_0x100f_3d91;/* jnz 0x100f3d91 */
            ii(0x100f_3d65, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_3d68, 5);  call(0x1010_1103, 0xd396);            /* call 0x10101103 */
            ii(0x100f_3d6d, 3);  test(ax, ax);                         /* test ax, ax */
            ii(0x100f_3d70, 2);  if(jnz(0x100f_3d8f, 0x1d)) goto l_0x100f_3d8f;/* jnz 0x100f3d8f */
            ii(0x100f_3d72, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_3d74, 5);  mov(eax, 0x101c_38b4);                /* mov eax, 0x101c38b4 */
            ii(0x100f_3d79, 5);  call(0x1007_6630, -0x7_d74e);         /* call 0x10076630 */
            ii(0x100f_3d7e, 7);  mov(memd[ss, ebp - 16], 0x402);       /* mov dword [ebp-0x10], 0x402 */
            ii(0x100f_3d85, 10);  mov(memd[ss, ebp - 332], 0x405);     /* mov dword [ebp-0x14c], 0x405 */
        l_0x100f_3d8f:
            ii(0x100f_3d8f, 2);  jmp(0x100f_3daf, 0x1e); goto l_0x100f_3daf;/* jmp 0x100f3daf */
        l_0x100f_3d91:
            ii(0x100f_3d91, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_3d94, 5);  call(0x1010_1103, 0xd36a);            /* call 0x10101103 */
            ii(0x100f_3d99, 3);  test(ax, ax);                         /* test ax, ax */
            ii(0x100f_3d9c, 2);  if(jnz(0x100f_3daf, 0x11)) goto l_0x100f_3daf;/* jnz 0x100f3daf */
            ii(0x100f_3d9e, 7);  mov(memd[ss, ebp - 16], 0x3f6);       /* mov dword [ebp-0x10], 0x3f6 */
            ii(0x100f_3da5, 10);  mov(memd[ss, ebp - 332], 0x401);     /* mov dword [ebp-0x14c], 0x401 */
        l_0x100f_3daf:
            ii(0x100f_3daf, 5);  jmp(0x100f_3ee4, 0x130); goto l_0x100f_3ee4;/* jmp 0x100f3ee4 */
        l_0x100f_3db4:
            ii(0x100f_3db4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_3db7, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100f_3dba, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100f_3dbd, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x100f_3dc0, 6);  push(memd[ds, eax + 0x101c_81d7]);    /* push dword [eax+0x101c81d7] */
            ii(0x100f_3dc6, 5);  mov(eax, StringDefinitions.SHasBeenCaptured);/* mov eax, 0x101a24ac */
            ii(0x100f_3dcb, 1);  push(eax);                            /* push eax */
            ii(0x100f_3dcc, 6);  lea(eax, memd[ss, ebp - 328]);        /* lea eax, [ebp-0x148] */
            ii(0x100f_3dd2, 1);  push(eax);                            /* push eax */
            ii(0x100f_3dd3, 5);  call(Definitions.sys_sprintf, 0x7_2129);/* call 0x10165f01 */
            ii(0x100f_3dd8, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x100f_3ddb, 7);  mov(memd[ss, ebp - 16], 0x3d5);       /* mov dword [ebp-0x10], 0x3d5 */
            ii(0x100f_3de2, 10);  mov(memd[ss, ebp - 332], 0x3d6);     /* mov dword [ebp-0x14c], 0x3d6 */
            ii(0x100f_3dec, 5);  jmp(0x100f_3ee4, 0xf3); goto l_0x100f_3ee4;/* jmp 0x100f3ee4 */
        l_0x100f_3df1:
            ii(0x100f_3df1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_3df4, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100f_3df7, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100f_3dfa, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x100f_3dfd, 6);  push(memd[ds, eax + 0x101c_81d7]);    /* push dword [eax+0x101c81d7] */
            ii(0x100f_3e03, 5);  mov(eax, StringDefinitions.SHasBeenDisabled);/* mov eax, 0x101a24c2 */
            ii(0x100f_3e08, 1);  push(eax);                            /* push eax */
            ii(0x100f_3e09, 6);  lea(eax, memd[ss, ebp - 328]);        /* lea eax, [ebp-0x148] */
            ii(0x100f_3e0f, 1);  push(eax);                            /* push eax */
            ii(0x100f_3e10, 5);  call(Definitions.sys_sprintf, 0x7_20ec);/* call 0x10165f01 */
            ii(0x100f_3e15, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x100f_3e18, 7);  mov(memd[ss, ebp - 16], 0x3db);       /* mov dword [ebp-0x10], 0x3db */
            ii(0x100f_3e1f, 10);  mov(memd[ss, ebp - 332], 0x3dc);     /* mov dword [ebp-0x14c], 0x3dc */
            ii(0x100f_3e29, 5);  jmp(0x100f_3ee4, 0xb6); goto l_0x100f_3ee4;/* jmp 0x100f3ee4 */
        l_0x100f_3e2e:
            ii(0x100f_3e2e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_3e31, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100f_3e34, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100f_3e37, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x100f_3e3a, 6);  push(memd[ds, eax + 0x101c_81d7]);    /* push dword [eax+0x101c81d7] */
            ii(0x100f_3e40, 5);  mov(eax, StringDefinitions.AttemptToCaptureS);/* mov eax, 0x101a24d8 */
            ii(0x100f_3e45, 1);  push(eax);                            /* push eax */
            ii(0x100f_3e46, 6);  lea(eax, memd[ss, ebp - 328]);        /* lea eax, [ebp-0x148] */
            ii(0x100f_3e4c, 1);  push(eax);                            /* push eax */
            ii(0x100f_3e4d, 5);  call(Definitions.sys_sprintf, 0x7_20af);/* call 0x10165f01 */
            ii(0x100f_3e52, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x100f_3e55, 7);  mov(memd[ss, ebp - 16], 0x3cf);       /* mov dword [ebp-0x10], 0x3cf */
            ii(0x100f_3e5c, 10);  mov(memd[ss, ebp - 332], 0x3d0);     /* mov dword [ebp-0x14c], 0x3d0 */
            ii(0x100f_3e66, 5);  jmp(0x100f_3ee4, 0x79); goto l_0x100f_3ee4;/* jmp 0x100f3ee4 */
        l_0x100f_3e6b:
            ii(0x100f_3e6b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_3e6e, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100f_3e71, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100f_3e74, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x100f_3e77, 6);  push(memd[ds, eax + 0x101c_81d7]);    /* push dword [eax+0x101c81d7] */
            ii(0x100f_3e7d, 5);  mov(eax, StringDefinitions.AttemptToDisableS);/* mov eax, 0x101a24ef */
            ii(0x100f_3e82, 1);  push(eax);                            /* push eax */
            ii(0x100f_3e83, 6);  lea(eax, memd[ss, ebp - 328]);        /* lea eax, [ebp-0x148] */
            ii(0x100f_3e89, 1);  push(eax);                            /* push eax */
            ii(0x100f_3e8a, 5);  call(Definitions.sys_sprintf, 0x7_2072);/* call 0x10165f01 */
            ii(0x100f_3e8f, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x100f_3e92, 7);  mov(memd[ss, ebp - 16], 0x3cf);       /* mov dword [ebp-0x10], 0x3cf */
            ii(0x100f_3e99, 10);  mov(memd[ss, ebp - 332], 0x3d0);     /* mov dword [ebp-0x14c], 0x3d0 */
            ii(0x100f_3ea3, 2);  jmp(0x100f_3ee4, 0x3f); goto l_0x100f_3ee4;/* jmp 0x100f3ee4 */
        l_0x100f_3ea5:
            ii(0x100f_3ea5, 2);  jmp(0x100f_3ee4, 0x3d); goto l_0x100f_3ee4;/* jmp 0x100f3ee4 */
        //  ii(0x100f_3ea7, 1);  nop();                                /* nop */
        //  ii(0x100f_3ea8, 24);  /* Служебная область с абсолютными адресами переходов. (0x100f_3c88, 0x100f_3d10, 0x100f_3db4, 0x100f_3df1, 0x100f_3e2e, 0x100f_3e6b). */
        l_0x100f_3ec0:
            ii(0x100f_3ec0, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100f_3ec3, 6);  mov(memb[ss, ebp - 340], al);         /* mov [ebp-0x154], al */
            ii(0x100f_3ec9, 7);  cmp(memb[ss, ebp - 340], 5);          /* cmp byte [ebp-0x154], 0x5 */
            ii(0x100f_3ed0, 2);  if(ja(0x100f_3ea5, -0x2d)) goto l_0x100f_3ea5;/* ja 0x100f3ea5 */
            ii(0x100f_3ed2, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_3ed4, 6);  mov(al, memb[ss, ebp - 340]);         /* mov al, [ebp-0x154] */
            ii(0x100f_3eda, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100f_3edd, 7);  /* jmp dword [cs:eax+0x100f3ea8] */
            switch (jmp_abs_switch(memd[cs, eax + 0x100f_3ea8]))
            {
                case 0x100f_3c88:
                    goto l_0x100f_3c88;
                case 0x100f_3d10:
                    goto l_0x100f_3d10;
                case 0x100f_3db4:
                    goto l_0x100f_3db4;
                case 0x100f_3df1:
                    goto l_0x100f_3df1;
                case 0x100f_3e2e:
                    goto l_0x100f_3e2e;
                case 0x100f_3e6b:
                    goto l_0x100f_3e6b;
                default:
                    throw new NotImplementedException();
            }
        l_0x100f_3ee4:
            ii(0x100f_3ee4, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_3ee6, 5);  mov(eax, 0x101c_38b4);                /* mov eax, 0x101c38b4 */
            ii(0x100f_3eeb, 5);  call(0x1013_ad71, 0x4_6e81);          /* call 0x1013ad71 */
            ii(0x100f_3ef0, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_3ef2, 2);  if(jz(0x100f_3f04, 0x10)) goto l_0x100f_3f04;/* jz 0x100f3f04 */
            ii(0x100f_3ef4, 5);  mov(edx, StringDefinitions.PressF1);  /* mov edx, 0x101a2506 */
            ii(0x100f_3ef9, 6);  lea(eax, memd[ss, ebp - 328]);        /* lea eax, [ebp-0x148] */
            ii(0x100f_3eff, 5);  call(Definitions.sys_strcat, 0x7_202d);/* call 0x10165f31 */
        l_0x100f_3f04:
            ii(0x100f_3f04, 6);  mov(ebx, memd[ds, 0x101c_38b8]);      /* mov ebx, [0x101c38b8] */
            ii(0x100f_3f0a, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100f_3f0d, 6);  mov(edx, memd[ds, 0x101c_38b6]);      /* mov edx, [0x101c38b6] */
            ii(0x100f_3f13, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100f_3f16, 6);  lea(eax, memd[ss, ebp - 344]);        /* lea eax, [ebp-0x158] */
            ii(0x100f_3f1c, 5);  call(0x1007_6aac, -0x7_d475);         /* call 0x10076aac */
            ii(0x100f_3f21, 2);  mov(ecx, memd[ds, eax]);              /* mov ecx, [eax] */
            ii(0x100f_3f23, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x100f_3f26, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100f_3f2b, 6);  lea(eax, memd[ss, ebp - 328]);        /* lea eax, [ebp-0x148] */
            ii(0x100f_3f31, 5);  call(0x1011_5b60, 0x2_1c2a);          /* call 0x10115b60 */
            ii(0x100f_3f36, 5);  cmp(memw[ss, ebp - 16], -1 /* 0xff */);/* cmp word [ebp-0x10], 0xffff */
            ii(0x100f_3f3b, 2);  if(jz(0x100f_3f5a, 0x1d)) goto l_0x100f_3f5a;/* jz 0x100f3f5a */
            ii(0x100f_3f3d, 5);  call(0x100d_5470, -0x1_ead2);         /* call 0x100d5470 */
            ii(0x100f_3f42, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x100f_3f45, 7);  movsx(ebx, memw[ss, ebp - 332]);      /* movsx ebx, word [ebp-0x14c] */
            ii(0x100f_3f4c, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100f_3f50, 5);  mov(eax, 0x101c_7278);                /* mov eax, 0x101c7278 */
            ii(0x100f_3f55, 5);  call(0x1013_daea, 0x4_9b90);          /* call 0x1013daea */
        l_0x100f_3f5a:
            ii(0x100f_3f5a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_3f5c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_3f5d, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_3f5e, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_3f5f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_3f60, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_3f61, 1);  ret();                                /* ret */
        }
    }
}

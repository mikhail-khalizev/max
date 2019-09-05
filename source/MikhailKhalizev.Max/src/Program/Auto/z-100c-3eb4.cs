using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_3eb4-e1b5f6df")]
        public void Method_100c_3eb4()
        {
            ii(0x100c_3eb4, 5);  push(0x30);                           /* push 0x30 */
            ii(0x100c_3eb9, 5);  call(Definitions.sys_check_available_stack_size, 0xa_1e94);/* call 0x10165d52 */
            ii(0x100c_3ebe, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_3ebf, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_3ec0, 1);  push(edx);                            /* push edx */
            ii(0x100c_3ec1, 1);  push(esi);                            /* push esi */
            ii(0x100c_3ec2, 1);  push(edi);                            /* push edi */
            ii(0x100c_3ec3, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_3ec4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_3ec6, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100c_3ecc, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_3ecf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_3ed2, 3);  mov(al, memb[ds, eax + 2]);           /* mov al, [eax+0x2] */
            ii(0x100c_3ed5, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
            ii(0x100c_3ed8, 5);  jmp(0x100c_4004, 0x127); goto l_0x100c_4004;/* jmp 0x100c4004 */
        l_0x100c_3edd:
            ii(0x100c_3edd, 5);  call(/* sys */ 0x1016_5e9b, 0xa_1fb9);/* call 0x10165e9b */
            ii(0x100c_3ee2, 3);  imul(eax, eax, 7);                    /* imul eax, eax, 0x7 */
            ii(0x100c_3ee5, 3);  shr(eax, 0xf);                        /* shr eax, 0xf */
            ii(0x100c_3ee8, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_3eea, 2);  if(jnz(0x100c_3ef5, 9)) goto l_0x100c_3ef5;/* jnz 0x100c3ef5 */
            ii(0x100c_3eec, 7);  mov(memd[ss, ebp - 12], 8);           /* mov dword [ebp-0xc], 0x8 */
            ii(0x100c_3ef3, 2);  jmp(0x100c_3efc, 7); goto l_0x100c_3efc;/* jmp 0x100c3efc */
        l_0x100c_3ef5:
            ii(0x100c_3ef5, 7);  mov(memd[ss, ebp - 12], 7);           /* mov dword [ebp-0xc], 0x7 */
        l_0x100c_3efc:
            ii(0x100c_3efc, 5);  jmp(0x100c_4021, 0x120); goto l_0x100c_4021;/* jmp 0x100c4021 */
        l_0x100c_3f01:
            ii(0x100c_3f01, 5);  call(/* sys */ 0x1016_5e9b, 0xa_1f95);/* call 0x10165e9b */
            ii(0x100c_3f06, 3);  imul(eax, eax, 7);                    /* imul eax, eax, 0x7 */
            ii(0x100c_3f09, 3);  shr(eax, 0xf);                        /* shr eax, 0xf */
            ii(0x100c_3f0c, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_3f0e, 2);  if(jnz(0x100c_3f19, 9)) goto l_0x100c_3f19;/* jnz 0x100c3f19 */
            ii(0x100c_3f10, 7);  mov(memd[ss, ebp - 12], 8);           /* mov dword [ebp-0xc], 0x8 */
            ii(0x100c_3f17, 2);  jmp(0x100c_3f20, 7); goto l_0x100c_3f20;/* jmp 0x100c3f20 */
        l_0x100c_3f19:
            ii(0x100c_3f19, 7);  mov(memd[ss, ebp - 12], 4);           /* mov dword [ebp-0xc], 0x4 */
        l_0x100c_3f20:
            ii(0x100c_3f20, 5);  jmp(0x100c_4021, 0xfc); goto l_0x100c_4021;/* jmp 0x100c4021 */
        l_0x100c_3f25:
            ii(0x100c_3f25, 5);  call(/* sys */ 0x1016_5e9b, 0xa_1f71);/* call 0x10165e9b */
            ii(0x100c_3f2a, 3);  imul(eax, eax, 7);                    /* imul eax, eax, 0x7 */
            ii(0x100c_3f2d, 3);  shr(eax, 0xf);                        /* shr eax, 0xf */
            ii(0x100c_3f30, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_3f32, 2);  if(jnz(0x100c_3f3d, 9)) goto l_0x100c_3f3d;/* jnz 0x100c3f3d */
            ii(0x100c_3f34, 7);  mov(memd[ss, ebp - 12], 8);           /* mov dword [ebp-0xc], 0x8 */
            ii(0x100c_3f3b, 2);  jmp(0x100c_3f44, 7); goto l_0x100c_3f44;/* jmp 0x100c3f44 */
        l_0x100c_3f3d:
            ii(0x100c_3f3d, 7);  mov(memd[ss, ebp - 12], 1);           /* mov dword [ebp-0xc], 0x1 */
        l_0x100c_3f44:
            ii(0x100c_3f44, 5);  jmp(0x100c_4021, 0xd8); goto l_0x100c_4021;/* jmp 0x100c4021 */
        l_0x100c_3f49:
            ii(0x100c_3f49, 5);  call(/* sys */ 0x1016_5e9b, 0xa_1f4d);/* call 0x10165e9b */
            ii(0x100c_3f4e, 3);  imul(eax, eax, 7);                    /* imul eax, eax, 0x7 */
            ii(0x100c_3f51, 3);  shr(eax, 0xf);                        /* shr eax, 0xf */
            ii(0x100c_3f54, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_3f56, 2);  if(jnz(0x100c_3f61, 9)) goto l_0x100c_3f61;/* jnz 0x100c3f61 */
            ii(0x100c_3f58, 7);  mov(memd[ss, ebp - 12], 8);           /* mov dword [ebp-0xc], 0x8 */
            ii(0x100c_3f5f, 2);  jmp(0x100c_3f68, 7); goto l_0x100c_3f68;/* jmp 0x100c3f68 */
        l_0x100c_3f61:
            ii(0x100c_3f61, 7);  mov(memd[ss, ebp - 12], 2);           /* mov dword [ebp-0xc], 0x2 */
        l_0x100c_3f68:
            ii(0x100c_3f68, 5);  jmp(0x100c_4021, 0xb4); goto l_0x100c_4021;/* jmp 0x100c4021 */
        l_0x100c_3f6d:
            ii(0x100c_3f6d, 7);  mov(memd[ss, ebp - 12], 6);           /* mov dword [ebp-0xc], 0x6 */
            ii(0x100c_3f74, 5);  jmp(0x100c_4021, 0xa8); goto l_0x100c_4021;/* jmp 0x100c4021 */
        l_0x100c_3f79:
            ii(0x100c_3f79, 7);  mov(memd[ss, ebp - 12], 5);           /* mov dword [ebp-0xc], 0x5 */
            ii(0x100c_3f80, 5);  jmp(0x100c_4021, 0x9c); goto l_0x100c_4021;/* jmp 0x100c4021 */
        l_0x100c_3f85:
            ii(0x100c_3f85, 7);  mov(memd[ss, ebp - 12], 6);           /* mov dword [ebp-0xc], 0x6 */
            ii(0x100c_3f8c, 5);  jmp(0x100c_4021, 0x90); goto l_0x100c_4021;/* jmp 0x100c4021 */
        l_0x100c_3f91:
            ii(0x100c_3f91, 5);  call(/* sys */ 0x1016_5e9b, 0xa_1f05);/* call 0x10165e9b */
            ii(0x100c_3f96, 3);  imul(eax, eax, 7);                    /* imul eax, eax, 0x7 */
            ii(0x100c_3f99, 3);  shr(eax, 0xf);                        /* shr eax, 0xf */
            ii(0x100c_3f9c, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_3f9e, 2);  if(jnz(0x100c_3fa9, 9)) goto l_0x100c_3fa9;/* jnz 0x100c3fa9 */
            ii(0x100c_3fa0, 7);  mov(memd[ss, ebp - 12], 8);           /* mov dword [ebp-0xc], 0x8 */
            ii(0x100c_3fa7, 2);  jmp(0x100c_3fba, 0x11); goto l_0x100c_3fba;/* jmp 0x100c3fba */
        l_0x100c_3fa9:
            ii(0x100c_3fa9, 5);  call(/* sys */ 0x1016_5e9b, 0xa_1eed);/* call 0x10165e9b */
            ii(0x100c_3fae, 3);  lea(eax, memd[ds, eax + eax * 2]);    /* lea eax, [eax+eax*2] */
            ii(0x100c_3fb1, 3);  shr(eax, 0xf);                        /* shr eax, 0xf */
            ii(0x100c_3fb4, 3);  add(eax, 3);                          /* add eax, 0x3 */
            ii(0x100c_3fb7, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x100c_3fba:
            ii(0x100c_3fba, 2);  jmp(0x100c_4021, 0x65); goto l_0x100c_4021;/* jmp 0x100c4021 */
        l_0x100c_3fbc:
            ii(0x100c_3fbc, 5);  call(/* sys */ 0x1016_5e9b, 0xa_1eda);/* call 0x10165e9b */
            ii(0x100c_3fc1, 3);  imul(eax, eax, 7);                    /* imul eax, eax, 0x7 */
            ii(0x100c_3fc4, 3);  shr(eax, 0xf);                        /* shr eax, 0xf */
            ii(0x100c_3fc7, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_3fc9, 2);  if(jnz(0x100c_3fd4, 9)) goto l_0x100c_3fd4;/* jnz 0x100c3fd4 */
            ii(0x100c_3fcb, 7);  mov(memd[ss, ebp - 12], 8);           /* mov dword [ebp-0xc], 0x8 */
            ii(0x100c_3fd2, 2);  jmp(0x100c_3fdb, 7); goto l_0x100c_3fdb;/* jmp 0x100c3fdb */
        l_0x100c_3fd4:
            ii(0x100c_3fd4, 7);  mov(memd[ss, ebp - 12], 3);           /* mov dword [ebp-0xc], 0x3 */
        l_0x100c_3fdb:
            ii(0x100c_3fdb, 2);  jmp(0x100c_4021, 0x44); goto l_0x100c_4021;/* jmp 0x100c4021 */
        l_0x100c_3fdd:
            ii(0x100c_3fdd, 2);  jmp(0x100c_4021, 0x42); goto l_0x100c_4021;/* jmp 0x100c4021 */
        //  ii(0x100c_3fdf, 1);  nop();                                /* nop */
        //  ii(0x100c_3fe0, 36);  /* Служебная область с абсолютными адресами переходов. (0x100c_3edd, 0x100c_3f01, 0x100c_3f25, 0x100c_3f49, 0x100c_3f6d, 0x100c_3f79, 0x100c_3f85, 0x100c_3f91, 0x100c_3fbc). */
        l_0x100c_4004:
            ii(0x100c_4004, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x100c_4007, 2);  dec(al);                              /* dec al */
            ii(0x100c_4009, 3);  mov(memb[ss, ebp - 20], al);          /* mov [ebp-0x14], al */
            ii(0x100c_400c, 4);  cmp(memb[ss, ebp - 20], 8);           /* cmp byte [ebp-0x14], 0x8 */
            ii(0x100c_4010, 2);  if(ja(0x100c_3fdd, -0x35)) goto l_0x100c_3fdd;/* ja 0x100c3fdd */
            ii(0x100c_4012, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100c_4014, 3);  mov(al, memb[ss, ebp - 20]);          /* mov al, [ebp-0x14] */
            ii(0x100c_4017, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100c_401a, 7);  /* jmp dword [cs:eax+0x100c3fe0] */
            switch (jmp_abs_switch(memd[cs, eax + 0x100c_3fe0]))
            {
                case 0x100c_3edd:
                    goto l_0x100c_3edd;
                case 0x100c_3f01:
                    goto l_0x100c_3f01;
                case 0x100c_3f25:
                    goto l_0x100c_3f25;
                case 0x100c_3f49:
                    goto l_0x100c_3f49;
                case 0x100c_3f6d:
                    goto l_0x100c_3f6d;
                case 0x100c_3f79:
                    goto l_0x100c_3f79;
                case 0x100c_3f85:
                    goto l_0x100c_3f85;
                case 0x100c_3f91:
                    goto l_0x100c_3f91;
                case 0x100c_3fbc:
                    goto l_0x100c_3fbc;
                default:
                    throw new NotImplementedException();
            }
        l_0x100c_4021:
            ii(0x100c_4021, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x100c_4025, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_4028, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x100c_402a, 2);  add(al, 0x6b);                        /* add al, 0x6b */
            ii(0x100c_402c, 3);  movsx(eax, al);                       /* movsx eax, al */
            ii(0x100c_402f, 5);  call(0x100c_aafc, 0x6ac8);            /* call 0x100caafc */
            ii(0x100c_4034, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_4037, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100c_403a, 5);  call(0x1013_602e, 0x7_1fef);          /* call 0x1013602e */
            ii(0x100c_403f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_4042, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_4045, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_4048, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_404a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_404b, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_404c, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_404d, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_404e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_404f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_4050, 1);  ret();                                /* ret */
        }
    }
}

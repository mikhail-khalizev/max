using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_3eac-4916e4fb")]
        public void Method_1008_3eac()
        {
            ii(0x1008_3eac, 5); push(0xa8);                             /* push 0xa8 */
            ii(0x1008_3eb1, 5); call(Definitions.sys_check_available_stack_size, 0xe_1e9c); /* call 0x10165d52 */
            ii(0x1008_3eb6, 1); push(esi);                              /* push esi */
            ii(0x1008_3eb7, 1); push(edi);                              /* push edi */
            ii(0x1008_3eb8, 1); push(ebp);                              /* push ebp */
            ii(0x1008_3eb9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_3ebb, 6); sub(esp, 0x94);                         /* sub esp, 0x94 */
            ii(0x1008_3ec1, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_3ec4, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1008_3ec7, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1008_3eca, 3); mov(memb[ss, ebp - 4], cl);             /* mov [ebp-0x4], cl */
            ii(0x1008_3ecd, 3); lea(edx, memd[ss, ebp - 0x18]);         /* lea edx, [ebp-0x18] */
            ii(0x1008_3ed0, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_3ed3, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_3ed6, 5); call(0x1008_9d7c, 0x5ea1);              /* call 0x10089d7c */
            ii(0x1008_3edb, 5); call(0x100a_2d3d, 0x1_ee5d);            /* call 0x100a2d3d */
            ii(0x1008_3ee0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_3ee3, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1008_3ee6, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_3ee9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_3eec, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1008_3eef, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_3ef2, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1008_3ef5, 5); call(0x1007_6aac, -0xd44e);             /* call 0x10076aac */
            ii(0x1008_3efa, 3); lea(edx, memd[ss, ebp - 0x1c]);         /* lea edx, [ebp-0x1c] */
            ii(0x1008_3efd, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1008_3f00, 5); call(0x1007_5e64, -0xe0a1);             /* call 0x10075e64 */
            ii(0x1008_3f05, 4); or(memb[ss, ebp - 0x24], 1);            /* or byte [ebp-0x24], 0x1 */
            ii(0x1008_3f09, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_3f0c, 5); call(0x1008_bbed, 0x7cdc);              /* call 0x1008bbed */
            ii(0x1008_3f11, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1008_3f14, 4); and(memb[ss, ebp - 0x24], -2 /* 0xfe */); /* and byte [ebp-0x24], 0xfe */
            ii(0x1008_3f18, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x1008_3f1b, 5); call(Definitions.my_ctor_0x101b_4184, -0xd430); /* call 0x10076af0 */
            ii(0x1008_3f20, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_3f23, 5); call(0x1008_36ad, -0x87b);              /* call 0x100836ad */
            ii(0x1008_3f28, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
            ii(0x1008_3f2b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_3f2e, 4); test(memb[ds, eax + 0x13], 1);          /* test byte [eax+0x13], 0x1 */
            ii(0x1008_3f32, 2); if(jz(0x1008_3f3d, 9)) goto l_0x1008_3f3d; /* jz 0x10083f3d */
            ii(0x1008_3f34, 7); mov(memd[ss, ebp - 0x38], 1);           /* mov dword [ebp-0x38], 0x1 */
            ii(0x1008_3f3b, 2); jmp(0x1008_3f44, 7); goto l_0x1008_3f44; /* jmp 0x10083f44 */
        l_0x1008_3f3d:
            ii(0x1008_3f3d, 7); mov(memd[ss, ebp - 0x38], 2);           /* mov dword [ebp-0x38], 0x2 */
        l_0x1008_3f44:
            ii(0x1008_3f44, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_3f46, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_3f49, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_3f4c, 5); call(0x1008_9c68, 0x5d17);              /* call 0x10089c68 */
            ii(0x1008_3f51, 5); call(0x1008_9f70, 0x601a);              /* call 0x10089f70 */
            ii(0x1008_3f56, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_3f58, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_3f5a, 3); mov(al, memb[ds, edx + 0x26]);          /* mov al, [edx+0x26] */
            ii(0x1008_3f5d, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1008_3f60, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_3f63, 5); cmp(memw[ds, eax + 8], 0x42);           /* cmp word [eax+0x8], 0x42 */
            ii(0x1008_3f68, 2); if(jnz(0x1008_3f7f, 0x15)) goto l_0x1008_3f7f; /* jnz 0x10083f7f */
            ii(0x1008_3f6a, 4); movsx(eax, memw[ss, ebp - 0x3c]);       /* movsx eax, word [ebp-0x3c] */
            ii(0x1008_3f6e, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1008_3f74, 6); mov(eax, memd[ds, eax + 0x101c_a6ab]);  /* mov eax, [eax+0x101ca6ab] */
            ii(0x1008_3f7a, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x1008_3f7d, 2); jmp(0x1008_3fb3, 0x34); goto l_0x1008_3fb3; /* jmp 0x10083fb3 */
        l_0x1008_3f7f:
            ii(0x1008_3f7f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_3f82, 5); call(0x1016_433b, 0xe_03b4);            /* call 0x1016433b */
            ii(0x1008_3f87, 2); test(al, al);                           /* test al, al */
            ii(0x1008_3f89, 2); if(jz(0x1008_3fa0, 0x15)) goto l_0x1008_3fa0; /* jz 0x10083fa0 */
            ii(0x1008_3f8b, 4); movsx(eax, memw[ss, ebp - 0x3c]);       /* movsx eax, word [ebp-0x3c] */
            ii(0x1008_3f8f, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1008_3f95, 6); mov(eax, memd[ds, eax + 0x101c_a6a7]);  /* mov eax, [eax+0x101ca6a7] */
            ii(0x1008_3f9b, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x1008_3f9e, 2); jmp(0x1008_3fb3, 0x13); goto l_0x1008_3fb3; /* jmp 0x10083fb3 */
        l_0x1008_3fa0:
            ii(0x1008_3fa0, 4); movsx(eax, memw[ss, ebp - 0x3c]);       /* movsx eax, word [ebp-0x3c] */
            ii(0x1008_3fa4, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1008_3faa, 6); mov(eax, memd[ds, eax + 0x101c_a6a3]);  /* mov eax, [eax+0x101ca6a3] */
            ii(0x1008_3fb0, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
        l_0x1008_3fb3:
            ii(0x1008_3fb3, 6); mov(memw[ss, ebp - 0x34], 0);           /* mov word [ebp-0x34], 0x0 */
            ii(0x1008_3fb9, 2); jmp(0x1008_3fc2, 7); goto l_0x1008_3fc2; /* jmp 0x10083fc2 */
        l_0x1008_3fbb:
            ii(0x1008_3fbb, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1008_3fbe, 4); inc(memw[ss, ebp - 0x34]);              /* inc word [ebp-0x34] */
        l_0x1008_3fc2:
            ii(0x1008_3fc2, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1008_3fc5, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1008_3fcc, 6); if(jge(0x1008_4067, 0x95)) goto l_0x1008_4067; /* jge 0x10084067 */
            ii(0x1008_3fd2, 6); mov(memw[ss, ebp - 0x32], 0);           /* mov word [ebp-0x32], 0x0 */
            ii(0x1008_3fd8, 2); jmp(0x1008_3fe1, 7); goto l_0x1008_3fe1; /* jmp 0x10083fe1 */
        l_0x1008_3fda:
            ii(0x1008_3fda, 3); mov(eax, memd[ss, ebp - 0x32]);         /* mov eax, [ebp-0x32] */
            ii(0x1008_3fdd, 4); inc(memw[ss, ebp - 0x32]);              /* inc word [ebp-0x32] */
        l_0x1008_3fe1:
            ii(0x1008_3fe1, 3); mov(eax, memd[ss, ebp - 0x32]);         /* mov eax, [ebp-0x32] */
            ii(0x1008_3fe4, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x1008_3feb, 6); if(jge(0x1008_4062, 0x71)) goto l_0x1008_4062; /* jge 0x10084062 */
            ii(0x1008_3ff1, 4); movsx(edx, memw[ss, ebp - 0x32]);       /* movsx edx, word [ebp-0x32] */
            ii(0x1008_3ff5, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x1008_3ffa, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_3ffd, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1008_4000, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1008_4004, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_4006, 6); mov(edx, memd[ds, 0x101c_9454]);        /* mov edx, [0x101c9454] */
            ii(0x1008_400c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_400e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_4010, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1008_4012, 4); movsx(eax, memw[ss, ebp - 0x38]);       /* movsx eax, word [ebp-0x38] */
            ii(0x1008_4016, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_4018, 2); if(jnz(0x1008_4046, 0x2c)) goto l_0x1008_4046; /* jnz 0x10084046 */
            ii(0x1008_401a, 4); cmp(memb[ss, ebp - 0x14], 0);           /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1008_401e, 2); if(jz(0x1008_4044, 0x24)) goto l_0x1008_4044; /* jz 0x10084044 */
            ii(0x1008_4020, 4); movsx(eax, memw[ss, ebp - 0x32]);       /* movsx eax, word [ebp-0x32] */
            ii(0x1008_4024, 6); mov(edx, memd[ds, 0x101c_8170]);        /* mov edx, [0x101c8170] */
            ii(0x1008_402a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_402d, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1008_4030, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1008_4034, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_4036, 3); add(eax, memd[ss, ebp - 0x40]);         /* add eax, [ebp-0x40] */
            ii(0x1008_4039, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1008_403b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_4040, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_4042, 2); if(jnz(0x1008_4046, 2)) goto l_0x1008_4046; /* jnz 0x10084046 */
        l_0x1008_4044:
            ii(0x1008_4044, 2); jmp(0x1008_4048, 2); goto l_0x1008_4048; /* jmp 0x10084048 */
        l_0x1008_4046:
            ii(0x1008_4046, 2); jmp(0x1008_405d, 0x15); goto l_0x1008_405d; /* jmp 0x1008405d */
        l_0x1008_4048:
            ii(0x1008_4048, 4); movsx(ebx, memw[ss, ebp - 0x32]);       /* movsx ebx, word [ebp-0x32] */
            ii(0x1008_404c, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1008_4050, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_4053, 5); call(0x1008_a728, 0x66d0);              /* call 0x1008a728 */
            ii(0x1008_4058, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1008_405a, 3); mov(memb[ds, eax], 2);                  /* mov byte [eax], 0x2 */
        l_0x1008_405d:
            ii(0x1008_405d, 5); jmp(0x1008_3fda, -0x88); goto l_0x1008_3fda; /* jmp 0x10083fda */
        l_0x1008_4062:
            ii(0x1008_4062, 5); jmp(0x1008_3fbb, -0xac); goto l_0x1008_3fbb; /* jmp 0x10083fbb */
        l_0x1008_4067:
            ii(0x1008_4067, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_406a, 4); test(memb[ds, eax + 0x13], 1);          /* test byte [eax+0x13], 0x1 */
            ii(0x1008_406e, 2); if(jz(0x1008_4079, 9)) goto l_0x1008_4079; /* jz 0x10084079 */
            ii(0x1008_4070, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_4073, 4); test(memb[ds, eax + 0x12], 0x80);       /* test byte [eax+0x12], 0x80 */
            ii(0x1008_4077, 2); if(jnz(0x1008_407e, 5)) goto l_0x1008_407e; /* jnz 0x1008407e */
        l_0x1008_4079:
            ii(0x1008_4079, 5); jmp(0x1008_4132, 0xb4); goto l_0x1008_4132; /* jmp 0x10084132 */
        l_0x1008_407e:
            ii(0x1008_407e, 6); mov(memw[ss, ebp - 0x34], 0);           /* mov word [ebp-0x34], 0x0 */
            ii(0x1008_4084, 2); jmp(0x1008_408d, 7); goto l_0x1008_408d; /* jmp 0x1008408d */
        l_0x1008_4086:
            ii(0x1008_4086, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1008_4089, 4); inc(memw[ss, ebp - 0x34]);              /* inc word [ebp-0x34] */
        l_0x1008_408d:
            ii(0x1008_408d, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1008_4090, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1008_4097, 6); if(jge(0x1008_4132, 0x95)) goto l_0x1008_4132; /* jge 0x10084132 */
            ii(0x1008_409d, 6); mov(memw[ss, ebp - 0x32], 0);           /* mov word [ebp-0x32], 0x0 */
            ii(0x1008_40a3, 2); jmp(0x1008_40ac, 7); goto l_0x1008_40ac; /* jmp 0x100840ac */
        l_0x1008_40a5:
            ii(0x1008_40a5, 3); mov(eax, memd[ss, ebp - 0x32]);         /* mov eax, [ebp-0x32] */
            ii(0x1008_40a8, 4); inc(memw[ss, ebp - 0x32]);              /* inc word [ebp-0x32] */
        l_0x1008_40ac:
            ii(0x1008_40ac, 3); mov(eax, memd[ss, ebp - 0x32]);         /* mov eax, [ebp-0x32] */
            ii(0x1008_40af, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x1008_40b6, 6); if(jge(0x1008_412d, 0x71)) goto l_0x1008_412d; /* jge 0x1008412d */
            ii(0x1008_40bc, 4); movsx(edx, memw[ss, ebp - 0x32]);       /* movsx edx, word [ebp-0x32] */
            ii(0x1008_40c0, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x1008_40c5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_40c8, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1008_40cb, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1008_40cf, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_40d1, 6); mov(edx, memd[ds, 0x101c_9454]);        /* mov edx, [0x101c9454] */
            ii(0x1008_40d7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_40d9, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1008_40db, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_40e0, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x1008_40e3, 2); if(jnz(0x1008_4111, 0x2c)) goto l_0x1008_4111; /* jnz 0x10084111 */
            ii(0x1008_40e5, 4); cmp(memb[ss, ebp - 0x14], 0);           /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1008_40e9, 2); if(jz(0x1008_410f, 0x24)) goto l_0x1008_410f; /* jz 0x1008410f */
            ii(0x1008_40eb, 4); movsx(eax, memw[ss, ebp - 0x32]);       /* movsx eax, word [ebp-0x32] */
            ii(0x1008_40ef, 6); mov(edx, memd[ds, 0x101c_8170]);        /* mov edx, [0x101c8170] */
            ii(0x1008_40f5, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_40f8, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1008_40fb, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1008_40ff, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_4101, 3); add(eax, memd[ss, ebp - 0x40]);         /* add eax, [ebp-0x40] */
            ii(0x1008_4104, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1008_4106, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_410b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_410d, 2); if(jnz(0x1008_4111, 2)) goto l_0x1008_4111; /* jnz 0x10084111 */
        l_0x1008_410f:
            ii(0x1008_410f, 2); jmp(0x1008_4113, 2); goto l_0x1008_4113; /* jmp 0x10084113 */
        l_0x1008_4111:
            ii(0x1008_4111, 2); jmp(0x1008_4128, 0x15); goto l_0x1008_4128; /* jmp 0x10084128 */
        l_0x1008_4113:
            ii(0x1008_4113, 4); movsx(ebx, memw[ss, ebp - 0x32]);       /* movsx ebx, word [ebp-0x32] */
            ii(0x1008_4117, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1008_411b, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_411e, 5); call(0x1008_a728, 0x6605);              /* call 0x1008a728 */
            ii(0x1008_4123, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1008_4125, 3); mov(memb[ds, eax], 2);                  /* mov byte [eax], 0x2 */
        l_0x1008_4128:
            ii(0x1008_4128, 5); jmp(0x1008_40a5, -0x88); goto l_0x1008_40a5; /* jmp 0x100840a5 */
        l_0x1008_412d:
            ii(0x1008_412d, 5); jmp(0x1008_4086, -0xac); goto l_0x1008_4086; /* jmp 0x10084086 */
        l_0x1008_4132:
            ii(0x1008_4132, 4); movsx(ebx, memb[ss, ebp - 4]);          /* movsx ebx, byte [ebp-0x4] */
            ii(0x1008_4136, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_4139, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_413c, 5); call(0x1008_a6f8, 0x65b7);              /* call 0x1008a6f8 */
            ii(0x1008_4141, 5); call(0x100c_9e2e, 0x4_5ce8);            /* call 0x100c9e2e */
            ii(0x1008_4146, 5); mov(eax, 0x24);                         /* mov eax, 0x24 */
            ii(0x1008_414b, 5); call(Definitions.sys_new, 0xe_1cb0);    /* call 0x10165e00 */
            ii(0x1008_4150, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x1008_4153, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1008_4156, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x1008_4159, 4); cmp(memd[ss, ebp - 0x48], 0);           /* cmp dword [ebp-0x48], 0x0 */
            ii(0x1008_415d, 2); if(jz(0x1008_4193, 0x34)) goto l_0x1008_4193; /* jz 0x10084193 */
            ii(0x1008_415f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_4161, 1); push(eax);                              /* push eax */
            ii(0x1008_4162, 3); lea(edx, memd[ss, ebp - 0x20]);         /* lea edx, [ebp-0x20] */
            ii(0x1008_4165, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x1008_4168, 5); call(0x1007_5e64, -0xe309);             /* call 0x10075e64 */
            ii(0x1008_416d, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1008_416f, 5); mov(ebx, 3);                            /* mov ebx, 0x3 */
            ii(0x1008_4174, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_4177, 5); call(0x1008_a6f8, 0x657c);              /* call 0x1008a6f8 */
            ii(0x1008_417c, 3); mov(esi, memd[ss, ebp - 0x44]);         /* mov esi, [ebp-0x44] */
            ii(0x1008_417f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_4181, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1008_4183, 5); call(0x100c_7dd0, 0x4_3c48);            /* call 0x100c7dd0 */
            ii(0x1008_4188, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x1008_418b, 3); mov(eax, memd[ss, ebp - 0x50]);         /* mov eax, [ebp-0x50] */
            ii(0x1008_418e, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
            ii(0x1008_4191, 2); jmp(0x1008_4199, 6); goto l_0x1008_4199; /* jmp 0x10084199 */
        l_0x1008_4193:
            ii(0x1008_4193, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1008_4196, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
        l_0x1008_4199:
            ii(0x1008_4199, 3); mov(edx, memd[ss, ebp - 0x54]);         /* mov edx, [ebp-0x54] */
            ii(0x1008_419c, 3); lea(eax, memd[ss, ebp - 0x58]);         /* lea eax, [ebp-0x58] */
            ii(0x1008_419f, 5); call(0x1008_96e0, 0x553c);              /* call 0x100896e0 */
            ii(0x1008_41a4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_41a6, 1); push(eax);                              /* push eax */
            ii(0x1008_41a7, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1008_41a9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_41ab, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_41ad, 3); lea(eax, memd[ss, ebp - 0x68]);         /* lea eax, [ebp-0x68] */
            ii(0x1008_41b0, 5); call(0x1008_b148, 0x6f93);              /* call 0x1008b148 */
            ii(0x1008_41b5, 3); lea(edx, memd[ss, ebp - 0x68]);         /* lea edx, [ebp-0x68] */
            ii(0x1008_41b8, 3); lea(eax, memd[ss, ebp - 0x58]);         /* lea eax, [ebp-0x58] */
            ii(0x1008_41bb, 5); call(0x1008_9640, 0x5480);              /* call 0x10089640 */
            ii(0x1008_41c0, 5); call(0x1008_98c4, 0x56ff);              /* call 0x100898c4 */
            ii(0x1008_41c5, 3); lea(edx, memd[ss, ebp - 0x18]);         /* lea edx, [ebp-0x18] */
            ii(0x1008_41c8, 3); lea(eax, memd[ss, ebp - 0x6c]);         /* lea eax, [ebp-0x6c] */
            ii(0x1008_41cb, 5); call(0x1007_5e64, -0xe36c);             /* call 0x10075e64 */
            ii(0x1008_41d0, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_41d2, 3); lea(edx, memd[ss, ebp - 0x20]);         /* lea edx, [ebp-0x20] */
            ii(0x1008_41d5, 3); lea(eax, memd[ss, ebp - 0x70]);         /* lea eax, [ebp-0x70] */
            ii(0x1008_41d8, 5); call(0x1007_5e64, -0xe379);             /* call 0x10075e64 */
            ii(0x1008_41dd, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1008_41df, 5); call(0x100a_5fca, 0x2_1de6);            /* call 0x100a5fca */
            ii(0x1008_41e4, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1008_41e7, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1008_41e9, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1008_41ec, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1008_41ee, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1008_41f0, 3); mov(memd[ss, ebp - 0x74], eax);         /* mov [ebp-0x74], eax */
            ii(0x1008_41f3, 7); mov(memd[ss, ebp - 0x78], 1);           /* mov dword [ebp-0x78], 0x1 */
            ii(0x1008_41fa, 2); jmp(0x1008_4202, 6); goto l_0x1008_4202; /* jmp 0x10084202 */
        l_0x1008_41fc:
            ii(0x1008_41fc, 3); mov(eax, memd[ss, ebp - 0x78]);         /* mov eax, [ebp-0x78] */
            ii(0x1008_41ff, 3); inc(memd[ss, ebp - 0x78]);              /* inc dword [ebp-0x78] */
        l_0x1008_4202:
            ii(0x1008_4202, 3); mov(eax, memd[ss, ebp - 0x78]);         /* mov eax, [ebp-0x78] */
            ii(0x1008_4205, 4); cmp(ax, memw[ss, ebp - 0x74]);          /* cmp ax, [ebp-0x74] */
            ii(0x1008_4209, 6); if(jge(0x1008_438e, 0x17f)) goto l_0x1008_438e; /* jge 0x1008438e */
            ii(0x1008_420f, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1008_4212, 3); sub(eax, memd[ss, ebp - 0x78]);         /* sub eax, [ebp-0x78] */
            ii(0x1008_4215, 4); mov(memw[ss, ebp - 0x34], ax);          /* mov [ebp-0x34], ax */
            ii(0x1008_4219, 3); mov(eax, memd[ss, ebp - 0x16]);         /* mov eax, [ebp-0x16] */
            ii(0x1008_421c, 3); add(eax, memd[ss, ebp - 0x78]);         /* add eax, [ebp-0x78] */
            ii(0x1008_421f, 4); mov(memw[ss, ebp - 0x32], ax);          /* mov [ebp-0x32], ax */
            ii(0x1008_4223, 7); mov(memd[ss, ebp - 0x7c], 0);           /* mov dword [ebp-0x7c], 0x0 */
            ii(0x1008_422a, 2); jmp(0x1008_4230, 4); goto l_0x1008_4230; /* jmp 0x10084230 */
        l_0x1008_422c:
            ii(0x1008_422c, 4); add(memd[ss, ebp - 0x7c], 2);           /* add dword [ebp-0x7c], 0x2 */
        l_0x1008_4230:
            ii(0x1008_4230, 4); movsx(eax, memw[ss, ebp - 0x7c]);       /* movsx eax, word [ebp-0x7c] */
            ii(0x1008_4234, 3); cmp(eax, 8);                            /* cmp eax, 0x8 */
            ii(0x1008_4237, 6); if(jge(0x1008_4389, 0x14c)) goto l_0x1008_4389; /* jge 0x10084389 */
            ii(0x1008_423d, 7); mov(memd[ss, ebp - 0x80], 0);           /* mov dword [ebp-0x80], 0x0 */
            ii(0x1008_4244, 2); jmp(0x1008_424c, 6); goto l_0x1008_424c; /* jmp 0x1008424c */
        l_0x1008_4246:
            ii(0x1008_4246, 3); mov(eax, memd[ss, ebp - 0x80]);         /* mov eax, [ebp-0x80] */
            ii(0x1008_4249, 3); inc(memd[ss, ebp - 0x80]);              /* inc dword [ebp-0x80] */
        l_0x1008_424c:
            ii(0x1008_424c, 4); movsx(eax, memw[ss, ebp - 0x78]);       /* movsx eax, word [ebp-0x78] */
            ii(0x1008_4250, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1008_4252, 4); movsx(edx, memw[ss, ebp - 0x80]);       /* movsx edx, word [ebp-0x80] */
            ii(0x1008_4256, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_4258, 6); if(jge(0x1008_4384, 0x126)) goto l_0x1008_4384; /* jge 0x10084384 */
            ii(0x1008_425e, 4); movsx(edx, memw[ss, ebp - 0x7c]);       /* movsx edx, word [ebp-0x7c] */
            ii(0x1008_4262, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x1008_4265, 5); mov(eax, 0x101c_5348);                  /* mov eax, 0x101c5348 */
            ii(0x1008_426a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1008_426c, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x1008_426f, 5); call(0x1008_b1a4, 0x6f30);              /* call 0x1008b1a4 */
            ii(0x1008_4274, 3); lea(edx, memd[ss, ebp - 0x34]);         /* lea edx, [ebp-0x34] */
            ii(0x1008_4277, 3); lea(eax, memd[ss, ebp - 0x68]);         /* lea eax, [ebp-0x68] */
            ii(0x1008_427a, 5); call(0x1010_82ce, 0x8_404f);            /* call 0x101082ce */
            ii(0x1008_427f, 2); test(al, al);                           /* test al, al */
            ii(0x1008_4281, 2); if(jz(0x1008_42a1, 0x1e)) goto l_0x1008_42a1; /* jz 0x100842a1 */
            ii(0x1008_4283, 4); movsx(ebx, memw[ss, ebp - 0x32]);       /* movsx ebx, word [ebp-0x32] */
            ii(0x1008_4287, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1008_428b, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_428e, 5); call(0x1008_a728, 0x6495);              /* call 0x1008a728 */
            ii(0x1008_4293, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1008_4295, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1008_4297, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_429c, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x1008_429f, 2); if(jz(0x1008_42a6, 5)) goto l_0x1008_42a6; /* jz 0x100842a6 */
        l_0x1008_42a1:
            ii(0x1008_42a1, 5); jmp(0x1008_437f, 0xd9); goto l_0x1008_437f; /* jmp 0x1008437f */
        l_0x1008_42a6:
            ii(0x1008_42a6, 3); lea(edx, memd[ss, ebp - 0x18]);         /* lea edx, [ebp-0x18] */
            ii(0x1008_42a9, 6); lea(eax, memd[ss, ebp - 0x84]);         /* lea eax, [ebp-0x84] */
            ii(0x1008_42af, 5); call(0x1007_5e64, -0xe450);             /* call 0x10075e64 */
            ii(0x1008_42b4, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_42b6, 3); lea(edx, memd[ss, ebp - 0x34]);         /* lea edx, [ebp-0x34] */
            ii(0x1008_42b9, 6); lea(eax, memd[ss, ebp - 0x88]);         /* lea eax, [ebp-0x88] */
            ii(0x1008_42bf, 5); call(0x1007_5e64, -0xe460);             /* call 0x10075e64 */
            ii(0x1008_42c4, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1008_42c6, 5); call(0x100a_5fca, 0x2_1cff);            /* call 0x100a5fca */
            ii(0x1008_42cb, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1008_42ce, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1008_42d0, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1008_42d3, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1008_42d5, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1008_42d7, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1008_42d9, 3); lea(edx, memd[ss, ebp - 0x1c]);         /* lea edx, [ebp-0x1c] */
            ii(0x1008_42dc, 6); lea(eax, memd[ss, ebp - 0x8c]);         /* lea eax, [ebp-0x8c] */
            ii(0x1008_42e2, 5); call(0x1007_5e64, -0xe483);             /* call 0x10075e64 */
            ii(0x1008_42e7, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_42e9, 3); lea(edx, memd[ss, ebp - 0x34]);         /* lea edx, [ebp-0x34] */
            ii(0x1008_42ec, 6); lea(eax, memd[ss, ebp - 0x90]);         /* lea eax, [ebp-0x90] */
            ii(0x1008_42f2, 5); call(0x1007_5e64, -0xe493);             /* call 0x10075e64 */
            ii(0x1008_42f7, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1008_42f9, 5); call(0x100a_5fca, 0x2_1ccc);            /* call 0x100a5fca */
            ii(0x1008_42fe, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1008_4301, 5); mov(ebx, 6);                            /* mov ebx, 0x6 */
            ii(0x1008_4306, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1008_4308, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1008_430b, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1008_430d, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1008_430f, 6); mov(memd[ss, ebp - 0x94], eax);         /* mov [ebp-0x94], eax */
            ii(0x1008_4315, 6); mov(eax, memd[ss, ebp - 0x94]);         /* mov eax, [ebp-0x94] */
            ii(0x1008_431b, 4); cmp(ax, memw[ss, ebp - 0x74]);          /* cmp ax, [ebp-0x74] */
            ii(0x1008_431f, 2); if(jge(0x1008_437f, 0x5e)) goto l_0x1008_437f; /* jge 0x1008437f */
            ii(0x1008_4321, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_4324, 4); cmp(memd[ds, eax + 0x3a], 0);           /* cmp dword [eax+0x3a], 0x0 */
            ii(0x1008_4328, 2); if(jz(0x1008_4341, 0x17)) goto l_0x1008_4341; /* jz 0x10084341 */
            ii(0x1008_432a, 4); movsx(edx, memw[ss, ebp - 0x32]);       /* movsx edx, word [ebp-0x32] */
            ii(0x1008_432e, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1008_4332, 5); call(0x1007_3d48, -0x1_05ef);           /* call 0x10073d48 */
            ii(0x1008_4337, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1008_433c, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x1008_433f, 2); if(jz(0x1008_437f, 0x3e)) goto l_0x1008_437f; /* jz 0x1008437f */
        l_0x1008_4341:
            ii(0x1008_4341, 5); mov(eax, 2);                            /* mov eax, 0x2 */
            ii(0x1008_4346, 1); push(eax);                              /* push eax */
            ii(0x1008_4347, 4); movsx(ecx, memw[ss, ebp - 0x32]);       /* movsx ecx, word [ebp-0x32] */
            ii(0x1008_434b, 4); movsx(ebx, memw[ss, ebp - 0x34]);       /* movsx ebx, word [ebp-0x34] */
            ii(0x1008_434f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_4352, 3); mov(edx, memd[ds, eax + 7]);            /* mov edx, [eax+0x7] */
            ii(0x1008_4355, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_4358, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_435b, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1008_435e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_4361, 5); call(0x1007_02b9, -0x1_40ad);           /* call 0x100702b9 */
            ii(0x1008_4366, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1008_4369, 2); if(jz(0x1008_437f, 0x14)) goto l_0x1008_437f; /* jz 0x1008437f */
            ii(0x1008_436b, 3); lea(edx, memd[ss, ebp - 0x34]);         /* lea edx, [ebp-0x34] */
            ii(0x1008_436e, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1008_4371, 5); call(0x1008_8b44, 0x47ce);              /* call 0x10088b44 */
            ii(0x1008_4376, 6); mov(eax, memd[ss, ebp - 0x94]);         /* mov eax, [ebp-0x94] */
            ii(0x1008_437c, 3); mov(memd[ss, ebp - 0x74], eax);         /* mov [ebp-0x74], eax */
        l_0x1008_437f:
            ii(0x1008_437f, 5); jmp(0x1008_4246, -0x13e); goto l_0x1008_4246; /* jmp 0x10084246 */
        l_0x1008_4384:
            ii(0x1008_4384, 5); jmp(0x1008_422c, -0x15d); goto l_0x1008_422c; /* jmp 0x1008422c */
        l_0x1008_4389:
            ii(0x1008_4389, 5); jmp(0x1008_41fc, -0x192); goto l_0x1008_41fc; /* jmp 0x100841fc */
        l_0x1008_438e:
            ii(0x1008_438e, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1008_4391, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_4394, 4); mov(memw[ds, edx + 0x1e], ax);          /* mov [edx+0x1e], ax */
            ii(0x1008_4398, 3); mov(eax, memd[ss, ebp - 0x1e]);         /* mov eax, [ebp-0x1e] */
            ii(0x1008_439b, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_439e, 4); mov(memw[ds, edx + 0x20], ax);          /* mov [edx+0x20], ax */
            ii(0x1008_43a2, 3); lea(edx, memd[ss, ebp - 0x20]);         /* lea edx, [ebp-0x20] */
            ii(0x1008_43a5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_43a8, 5); call(0x1007_5e64, -0xe549);             /* call 0x10075e64 */
            ii(0x1008_43ad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_43af, 3); lea(eax, memd[ss, ebp - 0x58]);         /* lea eax, [ebp-0x58] */
            ii(0x1008_43b2, 5); call(0x1008_9600, 0x5249);              /* call 0x10089600 */
            ii(0x1008_43b7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_43b9, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_43bc, 5); call(0x1008_bc9f, 0x78de);              /* call 0x1008bc9f */
            ii(0x1008_43c1, 2); jmp(0x1008_43d7, 0x14); goto l_0x1008_43d7; /* jmp 0x100843d7 */
        //  ii(0x1008_43c3, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_43c5, 3); lea(eax, memd[ss, ebp - 0x58]);         /* lea eax, [ebp-0x58] */
        //  ii(0x1008_43c8, 5); call(0x1008_9600, 0x5233);              /* call 0x10089600 */
        //  ii(0x1008_43cd, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_43cf, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
        //  ii(0x1008_43d2, 5); call(0x1008_bc9f, 0x78c8);              /* call 0x1008bc9f */
        l_0x1008_43d7:
            ii(0x1008_43d7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_43da, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_43dc, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_43dd, 1); pop(edi);                               /* pop edi */
            ii(0x1008_43de, 1); pop(esi);                               /* pop esi */
            ii(0x1008_43df, 1); ret();                                  /* ret */
        }
    }
}

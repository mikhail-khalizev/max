using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_43e0-bbf174e8")]
        public void Method_1008_43e0()
        {
            ii(0x1008_43e0, 5); push(0x70);                             /* push 0x70 */
            ii(0x1008_43e5, 5); call(Definitions.sys_check_available_stack_size, 0xe_1968); /* call 0x10165d52 */
            ii(0x1008_43ea, 1); push(ebx);                              /* push ebx */
            ii(0x1008_43eb, 1); push(ecx);                              /* push ecx */
            ii(0x1008_43ec, 1); push(esi);                              /* push esi */
            ii(0x1008_43ed, 1); push(edi);                              /* push edi */
            ii(0x1008_43ee, 1); push(ebp);                              /* push ebp */
            ii(0x1008_43ef, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_43f1, 6); sub(esp, 0x4c);                         /* sub esp, 0x4c */
            ii(0x1008_43f7, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_43fa, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x1008_43fd, 3); lea(edx, memd[ss, ebp - 0x18]);         /* lea edx, [ebp-0x18] */
            ii(0x1008_4400, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_4403, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_4406, 5); call(0x1008_9d7c, 0x5971);              /* call 0x10089d7c */
            ii(0x1008_440b, 5); call(0x100a_2d3d, 0x1_e92d);            /* call 0x100a2d3d */
            ii(0x1008_4410, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1008_4413, 5); call(Definitions.my_ctor_0x101b_4184, -0xd928); /* call 0x10076af0 */
            ii(0x1008_4418, 6); mov(ax, memw[ds, 0x101c_8172]);         /* mov ax, [0x101c8172] */
            ii(0x1008_441e, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1008_4421, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_4424, 3); mov(edx, memd[ds, eax + 7]);            /* mov edx, [eax+0x7] */
            ii(0x1008_4427, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_442a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_442d, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_4430, 5); call(0x1008_9d7c, 0x5947);              /* call 0x10089d7c */
            ii(0x1008_4435, 5); call(0x1008_9f70, 0x5b36);              /* call 0x10089f70 */
            ii(0x1008_443a, 5); call(0x1007_6074, -0xe3cb);             /* call 0x10076074 */
            ii(0x1008_443f, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
            ii(0x1008_4442, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_4445, 4); cmp(memb[ds, eax + 0x15], 3);           /* cmp byte [eax+0x15], 0x3 */
            ii(0x1008_4449, 2); if(jl(0x1008_444f, 4)) goto l_0x1008_444f; /* jl 0x1008444f */
            ii(0x1008_444b, 4); mov(memb[ss, ebp - 4], 2);              /* mov byte [ebp-0x4], 0x2 */
        l_0x1008_444f:
            ii(0x1008_444f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_4452, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_4455, 5); call(0x1007_6574, -0xdee6);             /* call 0x10076574 */
            ii(0x1008_445a, 3); mov(al, memb[ds, eax + 0x54]);          /* mov al, [eax+0x54] */
            ii(0x1008_445d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_4462, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_4464, 2); if(jnz(0x1008_446c, 6)) goto l_0x1008_446c; /* jnz 0x1008446c */
            ii(0x1008_4466, 4); cmp(memb[ss, ebp - 0x14], 0);           /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1008_446a, 2); if(jz(0x1008_446e, 2)) goto l_0x1008_446e; /* jz 0x1008446e */
        l_0x1008_446c:
            ii(0x1008_446c, 2); jmp(0x1008_4477, 9); goto l_0x1008_4477; /* jmp 0x10084477 */
        l_0x1008_446e:
            ii(0x1008_446e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_4471, 4); cmp(memb[ds, eax + 0x15], 6);           /* cmp byte [eax+0x15], 0x6 */
            ii(0x1008_4475, 2); if(jl(0x1008_4479, 2)) goto l_0x1008_4479; /* jl 0x10084479 */
        l_0x1008_4477:
            ii(0x1008_4477, 2); jmp(0x1008_447d, 4); goto l_0x1008_447d; /* jmp 0x1008447d */
        l_0x1008_4479:
            ii(0x1008_4479, 4); mov(memb[ss, ebp - 4], 3);              /* mov byte [ebp-0x4], 0x3 */
        l_0x1008_447d:
            ii(0x1008_447d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_4480, 4); cmp(memb[ds, eax + 0x15], 1);           /* cmp byte [eax+0x15], 0x1 */
            ii(0x1008_4484, 2); if(jnz(0x1008_448a, 4)) goto l_0x1008_448a; /* jnz 0x1008448a */
            ii(0x1008_4486, 4); mov(memb[ss, ebp - 4], 3);              /* mov byte [ebp-0x4], 0x3 */
        l_0x1008_448a:
            ii(0x1008_448a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_448d, 4); cmp(memb[ds, eax + 0x46], 0);           /* cmp byte [eax+0x46], 0x0 */
            ii(0x1008_4491, 2); if(jz(0x1008_449c, 9)) goto l_0x1008_449c; /* jz 0x1008449c */
            ii(0x1008_4493, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_4497, 5); jmp(0x1008_46db, 0x23f); goto l_0x1008_46db; /* jmp 0x100846db */
        l_0x1008_449c:
            ii(0x1008_449c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_449f, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_44a2, 5); call(0x1007_6574, -0xdf33);             /* call 0x10076574 */
            ii(0x1008_44a7, 4); test(memb[ds, eax + 0x12], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x1008_44ab, 2); if(jnz(0x1008_44b6, 9)) goto l_0x1008_44b6; /* jnz 0x100844b6 */
            ii(0x1008_44ad, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_44b0, 4); cmp(memb[ds, eax + 0x15], 4);           /* cmp byte [eax+0x15], 0x4 */
            ii(0x1008_44b4, 2); if(jl(0x1008_44b8, 2)) goto l_0x1008_44b8; /* jl 0x100844b8 */
        l_0x1008_44b6:
            ii(0x1008_44b6, 2); jmp(0x1008_44c1, 9); goto l_0x1008_44c1; /* jmp 0x100844c1 */
        l_0x1008_44b8:
            ii(0x1008_44b8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_44bb, 4); cmp(memb[ds, eax + 0x15], 1);           /* cmp byte [eax+0x15], 0x1 */
            ii(0x1008_44bf, 2); if(jnz(0x1008_44f3, 0x32)) goto l_0x1008_44f3; /* jnz 0x100844f3 */
        l_0x1008_44c1:
            ii(0x1008_44c1, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1008_44c5, 1); push(eax);                              /* push eax */
            ii(0x1008_44c6, 3); lea(edx, memd[ss, ebp - 0x18]);         /* lea edx, [ebp-0x18] */
            ii(0x1008_44c9, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1008_44cc, 5); call(0x1007_5e64, -0xe66d);             /* call 0x10075e64 */
            ii(0x1008_44d1, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1008_44d3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_44d6, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_44d9, 5); call(0x1007_65d0, -0xdf0e);             /* call 0x100765d0 */
            ii(0x1008_44de, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_44e0, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_44e3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_44e6, 5); call(0x1008_3755, -0xd96);              /* call 0x10083755 */
            ii(0x1008_44eb, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x1008_44ee, 5); jmp(0x1008_46db, 0x1e8); goto l_0x1008_46db; /* jmp 0x100846db */
        l_0x1008_44f3:
            ii(0x1008_44f3, 4); movsx(ecx, memb[ss, ebp - 4]);          /* movsx ecx, byte [ebp-0x4] */
            ii(0x1008_44f7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_44fa, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_44fd, 5); call(0x1007_65d0, -0xdf32);             /* call 0x100765d0 */
            ii(0x1008_4502, 3); lea(edx, memd[ss, ebp - 0x28]);         /* lea edx, [ebp-0x28] */
            ii(0x1008_4505, 3); mov(esi, memd[ss, ebp - 8]);            /* mov esi, [ebp-0x8] */
            ii(0x1008_4508, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_450a, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1008_450c, 5); call(0x1008_3eac, -0x665);              /* call 0x10083eac */
            ii(0x1008_4511, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_4513, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1008_4516, 5); call(0x1008_8b44, 0x4629);              /* call 0x10088b44 */
            ii(0x1008_451b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_451e, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_4521, 5); call(0x1007_6574, -0xdfb2);             /* call 0x10076574 */
            ii(0x1008_4526, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x1008_452a, 4); cmp(ax, memw[ss, ebp - 0x1c]);          /* cmp ax, [ebp-0x1c] */
            ii(0x1008_452e, 2); if(jnz(0x1008_4545, 0x15)) goto l_0x1008_4545; /* jnz 0x10084545 */
            ii(0x1008_4530, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_4533, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_4536, 5); call(0x1007_6574, -0xdfc7);             /* call 0x10076574 */
            ii(0x1008_453b, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x1008_453f, 4); cmp(ax, memw[ss, ebp - 0x1a]);          /* cmp ax, [ebp-0x1a] */
            ii(0x1008_4543, 2); if(jz(0x1008_4547, 2)) goto l_0x1008_4547; /* jz 0x10084547 */
        l_0x1008_4545:
            ii(0x1008_4545, 2); jmp(0x1008_4563, 0x1c); goto l_0x1008_4563; /* jmp 0x10084563 */
        l_0x1008_4547:
            ii(0x1008_4547, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_454a, 4); mov(memb[ds, eax + 0x46], 1);           /* mov byte [eax+0x46], 0x1 */
            ii(0x1008_454e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_4551, 5); call(0x1008_61ff, 0x1ca9);              /* call 0x100861ff */
            ii(0x1008_4556, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_4559, 5); call(0x1008_3369, -0x11f5);             /* call 0x10083369 */
            ii(0x1008_455e, 5); jmp(0x1008_46d7, 0x174); goto l_0x1008_46d7; /* jmp 0x100846d7 */
        l_0x1008_4563:
            ii(0x1008_4563, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_4566, 4); cmp(memb[ds, eax + 0x15], 5);           /* cmp byte [eax+0x15], 0x5 */
            ii(0x1008_456a, 6); if(jge(0x1008_4613, 0xa3)) goto l_0x1008_4613; /* jge 0x10084613 */
            ii(0x1008_4570, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_4573, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_4576, 5); call(0x1008_9d08, 0x578d);              /* call 0x10089d08 */
            ii(0x1008_457b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_457d, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_4580, 5); call(0x1008_9be4, 0x565f);              /* call 0x10089be4 */
            ii(0x1008_4585, 4); or(memb[ss, ebp - 0x10], 1);            /* or byte [ebp-0x10], 0x1 */
            ii(0x1008_4589, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_458c, 5); call(0x1007_64fc, -0xe095);             /* call 0x100764fc */
            ii(0x1008_4591, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1008_4594, 4); and(memb[ss, ebp - 0x10], -2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1008_4598, 2); jmp(0x1008_45a2, 8); goto l_0x1008_45a2; /* jmp 0x100845a2 */
        l_0x1008_459a:
            ii(0x1008_459a, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_459d, 5); call(0x1007_6bf8, -0xd9aa);             /* call 0x10076bf8 */
        l_0x1008_45a2:
            ii(0x1008_45a2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_45a4, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_45a7, 5); call(0x1013_ad71, 0xb_67c5);            /* call 0x1013ad71 */
            ii(0x1008_45ac, 2); test(al, al);                           /* test al, al */
            ii(0x1008_45ae, 2); if(jz(0x1008_45ff, 0x4f)) goto l_0x1008_45ff; /* jz 0x100845ff */
            ii(0x1008_45b0, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_45b3, 5); call(0x1008_9acc, 0x5514);              /* call 0x10089acc */
            ii(0x1008_45b8, 5); call(0x1008_9fc4, 0x5a07);              /* call 0x10089fc4 */
            ii(0x1008_45bd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_45bf, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_45c2, 5); call(0x1007_643c, -0xe18b);             /* call 0x1007643c */
            ii(0x1008_45c7, 2); jmp(0x1008_45d1, 8); goto l_0x1008_45d1; /* jmp 0x100845d1 */
        l_0x1008_45c9:
            ii(0x1008_45c9, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_45cc, 5); call(0x1007_6bf8, -0xd9d9);             /* call 0x10076bf8 */
        l_0x1008_45d1:
            ii(0x1008_45d1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_45d3, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_45d6, 5); call(0x1013_ad71, 0xb_6796);            /* call 0x1013ad71 */
            ii(0x1008_45db, 2); test(al, al);                           /* test al, al */
            ii(0x1008_45dd, 2); if(jz(0x1008_45fd, 0x1e)) goto l_0x1008_45fd; /* jz 0x100845fd */
            ii(0x1008_45df, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_45e2, 5); call(0x1007_63a0, -0xe247);             /* call 0x100763a0 */
            ii(0x1008_45e7, 6); mov(memw[ds, eax + 0x1e], 0);           /* mov word [eax+0x1e], 0x0 */
            ii(0x1008_45ed, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_45f0, 5); call(0x1007_63a0, -0xe255);             /* call 0x100763a0 */
            ii(0x1008_45f5, 6); mov(memw[ds, eax + 0x20], 0);           /* mov word [eax+0x20], 0x0 */
            ii(0x1008_45fb, 2); jmp(0x1008_45c9, -0x34); goto l_0x1008_45c9; /* jmp 0x100845c9 */
        l_0x1008_45fd:
            ii(0x1008_45fd, 2); jmp(0x1008_459a, -0x65); goto l_0x1008_459a; /* jmp 0x1008459a */
        l_0x1008_45ff:
            ii(0x1008_45ff, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_4601, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_4604, 5); call(0x1007_5f6c, -0xe69d);             /* call 0x10075f6c */
            ii(0x1008_4609, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_460b, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_460e, 5); call(0x1008_9044, 0x4a31);              /* call 0x10089044 */
        l_0x1008_4613:
            ii(0x1008_4613, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_4616, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_4619, 5); call(0x1007_6574, -0xe0aa);             /* call 0x10076574 */
            ii(0x1008_461e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_4620, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1008_4623, 4); mov(memw[ds, edx + 0x1e], ax);          /* mov [edx+0x1e], ax */
            ii(0x1008_4627, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_462a, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_462d, 5); call(0x1007_6574, -0xe0be);             /* call 0x10076574 */
            ii(0x1008_4632, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_4634, 3); mov(eax, memd[ss, ebp - 0x1a]);         /* mov eax, [ebp-0x1a] */
            ii(0x1008_4637, 4); mov(memw[ds, edx + 0x20], ax);          /* mov [edx+0x20], ax */
            ii(0x1008_463b, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x1008_4640, 5); call(Definitions.sys_new, 0xe_17bb);    /* call 0x10165e00 */
            ii(0x1008_4645, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1008_4648, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1008_464b, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1008_464e, 4); cmp(memd[ss, ebp - 0x3c], 0);           /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x1008_4652, 2); if(jz(0x1008_4690, 0x3c)) goto l_0x1008_4690; /* jz 0x10084690 */
            ii(0x1008_4654, 5); mov(eax, 0x100b_0ebb);                  /* mov eax, 0x100b0ebb */
            ii(0x1008_4659, 1); push(eax);                              /* push eax */
            ii(0x1008_465a, 3); lea(edx, memd[ss, ebp - 0x1c]);         /* lea edx, [ebp-0x1c] */
            ii(0x1008_465d, 3); lea(eax, memd[ss, ebp - 0x40]);         /* lea eax, [ebp-0x40] */
            ii(0x1008_4660, 5); call(0x1007_5e64, -0xe801);             /* call 0x10075e64 */
            ii(0x1008_4665, 1); push(eax);                              /* push eax */
            ii(0x1008_4666, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1008_466a, 1); push(eax);                              /* push eax */
            ii(0x1008_466b, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1008_466d, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1008_4670, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_4673, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_4676, 5); call(0x1007_65d0, -0xe0ab);             /* call 0x100765d0 */
            ii(0x1008_467b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_467d, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1008_4680, 5); call(0x100a_c220, 0x2_7b9b);            /* call 0x100ac220 */
            ii(0x1008_4685, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x1008_4688, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1008_468b, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x1008_468e, 2); jmp(0x1008_4696, 6); goto l_0x1008_4696; /* jmp 0x10084696 */
        l_0x1008_4690:
            ii(0x1008_4690, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1008_4693, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
        l_0x1008_4696:
            ii(0x1008_4696, 3); mov(edx, memd[ss, ebp - 0x48]);         /* mov edx, [ebp-0x48] */
            ii(0x1008_4699, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x1008_469c, 5); call(0x1008_a5f0, 0x5f4f);              /* call 0x1008a5f0 */
            ii(0x1008_46a1, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1008_46a6, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x1008_46a9, 5); call(0x1008_a520, 0x5e72);              /* call 0x1008a520 */
            ii(0x1008_46ae, 5); call(0x1008_a6a4, 0x5ff1);              /* call 0x1008a6a4 */
            ii(0x1008_46b3, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x1008_46b6, 5); call(0x1008_a57c, 0x5ec1);              /* call 0x1008a57c */
            ii(0x1008_46bb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_46bd, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_46c2, 5); call(0x100a_4d50, 0x2_0689);            /* call 0x100a4d50 */
            ii(0x1008_46c7, 4); mov(memb[ss, ebp - 0xc], 1);            /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_46cb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_46cd, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x1008_46d0, 5); call(0x1008_8d4c, 0x4677);              /* call 0x10088d4c */
            ii(0x1008_46d5, 2); jmp(0x1008_46db, 4); goto l_0x1008_46db; /* jmp 0x100846db */
        l_0x1008_46d7:
            ii(0x1008_46d7, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
        l_0x1008_46db:
            ii(0x1008_46db, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1008_46de, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_46e0, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_46e1, 1); pop(edi);                               /* pop edi */
            ii(0x1008_46e2, 1); pop(esi);                               /* pop esi */
            ii(0x1008_46e3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_46e4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_46e5, 1); ret();                                  /* ret */
        }
    }
}

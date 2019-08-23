using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_40b3-43388bc4")]
        public void Method_100a_40b3()
        {
            ii(0x100a_40b3, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100a_40b8, 5); calld(Definitions.sys_check_available_stack_size, 0xc_1c95); /* call 0x10165d52 */
            ii(0x100a_40bd, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_40be, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_40bf, 1); pushd(edx);                             /* push edx */
            ii(0x100a_40c0, 1); pushd(esi);                             /* push esi */
            ii(0x100a_40c1, 1); pushd(edi);                             /* push edi */
            ii(0x100a_40c2, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_40c3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_40c5, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100a_40cb, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_40ce, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_40d0, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100a_40d5, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_40d8, 6); if(jzd(0x100a_4323, 0x245)) goto l_0x100a_4323; /* jz 0x100a4323 */
            ii(0x100a_40de, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_40e0, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100a_40e5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_40e7, 2); if(jnzd(0x100a_410a, 0x21)) goto l_0x100a_410a; /* jnz 0x100a410a */
            ii(0x100a_40e9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_40eb, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100a_40f0, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_40f6, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100a_40fc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_4101, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_4104, 6); if(jnzd(0x100a_4323, 0x219)) goto l_0x100a_4323; /* jnz 0x100a4323 */
        l_0x100a_410a:
            ii(0x100a_410a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_410d, 5); calld(0x1008_aef4, -0x1_921e);          /* call 0x1008aef4 */
            ii(0x100a_4112, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_4114, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_4117, 5); calld(0x1008_ae70, -0x1_92ac);          /* call 0x1008ae70 */
            ii(0x100a_411c, 2); jmpd(0x100a_4126, 0x8); goto l_0x100a_4126; /* jmp 0x100a4126 */
        l_0x100a_411e:
            ii(0x100a_411e, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_4121, 5); calld(0x1007_6bf8, -0x2_d52e);          /* call 0x10076bf8 */
        l_0x100a_4126:
            ii(0x100a_4126, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4128, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_412b, 5); calld(0x1013_ad71, 0x9_6c41);           /* call 0x1013ad71 */
            ii(0x100a_4130, 2); test(al, al);                           /* test al, al */
            ii(0x100a_4132, 2); if(jzd(0x100a_4186, 0x52)) goto l_0x100a_4186; /* jz 0x100a4186 */
            ii(0x100a_4134, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_4136, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100a_413b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_413d, 2); if(jnzd(0x100a_415a, 0x1b)) goto l_0x100a_415a; /* jnz 0x100a415a */
            ii(0x100a_413f, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_4142, 5); calld(0x1008_adc4, -0x1_9383);          /* call 0x1008adc4 */
            ii(0x100a_4147, 5); calld(0x1008_ad90, -0x1_93bc);          /* call 0x1008ad90 */
            ii(0x100a_414c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_414f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_4151, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100a_4156, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_4158, 2); if(jnzd(0x100a_4184, 0x2a)) goto l_0x100a_4184; /* jnz 0x100a4184 */
        l_0x100a_415a:
            ii(0x100a_415a, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_415d, 5); calld(0x1008_adc4, -0x1_939e);          /* call 0x1008adc4 */
            ii(0x100a_4162, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_4165, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_4168, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100a_416b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_416e, 3); calld_abs(memd_a32[ds, edx + 0x4c]);    /* call dword [edx+0x4c] */
            ii(0x100a_4171, 2); test(al, al);                           /* test al, al */
            ii(0x100a_4173, 2); if(jzd(0x100a_4184, 0xf)) goto l_0x100a_4184; /* jz 0x100a4184 */
            ii(0x100a_4175, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4177, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_417a, 5); calld(0x1008_8bbc, -0x1_b5c3);          /* call 0x10088bbc */
            ii(0x100a_417f, 5); jmpd(0x100a_4323, 0x19f); goto l_0x100a_4323; /* jmp 0x100a4323 */
        l_0x100a_4184:
            ii(0x100a_4184, 2); jmpd(0x100a_411e, -0x68); goto l_0x100a_411e; /* jmp 0x100a411e */
        l_0x100a_4186:
            ii(0x100a_4186, 5); mov(eax, memd_a32[ds, 0x101c_31be]);    /* mov eax, [0x101c31be] */
            ii(0x100a_418b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_418e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_4190, 6); if(jnzd(0x100a_4319, 0x183)) goto l_0x100a_4319; /* jnz 0x100a4319 */
            ii(0x100a_4196, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_4199, 3); add(eax, 0x28);                         /* add eax, 0x28 */
            ii(0x100a_419c, 5); calld(0x1007_6338, -0x2_de69);          /* call 0x10076338 */
            ii(0x100a_41a1, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x100a_41a4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_41a6, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_41a8, 5); calld(0x1007_64b8, -0x2_dcf5);          /* call 0x100764b8 */
            ii(0x100a_41ad, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x100a_41b4, 2); jmpd(0x100a_41be, 0x8); goto l_0x100a_41be; /* jmp 0x100a41be */
        l_0x100a_41b6:
            ii(0x100a_41b6, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_41b9, 5); calld(0x1007_6bf8, -0x2_d5c6);          /* call 0x10076bf8 */
        l_0x100a_41be:
            ii(0x100a_41be, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_41c0, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_41c3, 5); calld(0x1013_ad71, 0x9_6ba9);           /* call 0x1013ad71 */
            ii(0x100a_41c8, 2); test(al, al);                           /* test al, al */
            ii(0x100a_41ca, 6); if(jzd(0x100a_430f, 0x13f)) goto l_0x100a_430f; /* jz 0x100a430f */
            ii(0x100a_41d0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_41d2, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100a_41d7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_41d9, 2); if(jnzd(0x100a_41f3, 0x18)) goto l_0x100a_41f3; /* jnz 0x100a41f3 */
            ii(0x100a_41db, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_41de, 5); calld(0x1007_63a0, -0x2_de43);          /* call 0x100763a0 */
            ii(0x100a_41e3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_41e5, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100a_41e8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_41ea, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100a_41ef, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_41f1, 2); if(jnzd(0x100a_4207, 0x14)) goto l_0x100a_4207; /* jnz 0x100a4207 */
        l_0x100a_41f3:
            ii(0x100a_41f3, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_41f6, 5); calld(0x1007_63a0, -0x2_de5b);          /* call 0x100763a0 */
            ii(0x100a_41fb, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x100a_41fe, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_4203, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_4205, 2); if(jgd(0x100a_4209, 0x2)) goto l_0x100a_4209; /* jg 0x100a4209 */
        l_0x100a_4207:
            ii(0x100a_4207, 2); jmpd(0x100a_421d, 0x14); goto l_0x100a_421d; /* jmp 0x100a421d */
        l_0x100a_4209:
            ii(0x100a_4209, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_420c, 5); calld(0x1007_63a0, -0x2_de71);          /* call 0x100763a0 */
            ii(0x100a_4211, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x100a_4214, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_4219, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_421b, 2); if(jgd(0x100a_421f, 0x2)) goto l_0x100a_421f; /* jg 0x100a421f */
        l_0x100a_421d:
            ii(0x100a_421d, 2); jmpd(0x100a_4230, 0x11); goto l_0x100a_4230; /* jmp 0x100a4230 */
        l_0x100a_421f:
            ii(0x100a_421f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_4222, 5); calld(0x1007_63d4, -0x2_de53);          /* call 0x100763d4 */
            ii(0x100a_4227, 5); calld(0x100a_2edb, -0x1351);            /* call 0x100a2edb */
            ii(0x100a_422c, 2); test(al, al);                           /* test al, al */
            ii(0x100a_422e, 2); if(jnzd(0x100a_4232, 0x2)) goto l_0x100a_4232; /* jnz 0x100a4232 */
        l_0x100a_4230:
            ii(0x100a_4230, 2); jmpd(0x100a_4258, 0x26); goto l_0x100a_4258; /* jmp 0x100a4258 */
        l_0x100a_4232:
            ii(0x100a_4232, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_4235, 5); calld(0x1007_63a0, -0x2_de9a);          /* call 0x100763a0 */
            ii(0x100a_423a, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100a_423d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_4242, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_4248, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100a_424e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_4253, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_4256, 2); if(jzd(0x100a_425d, 0x5)) goto l_0x100a_425d; /* jz 0x100a425d */
        l_0x100a_4258:
            ii(0x100a_4258, 5); jmpd(0x100a_430a, 0xad); goto l_0x100a_430a; /* jmp 0x100a430a */
        l_0x100a_425d:
            ii(0x100a_425d, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_4260, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
            ii(0x100a_4263, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_4266, 5); calld(0x1007_63a0, -0x2_decb);          /* call 0x100763a0 */
            ii(0x100a_426b, 5); calld(0x1015_26ac, 0xa_e43c);           /* call 0x101526ac */
            ii(0x100a_4270, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_4272, 2); if(jzd(0x100a_42a2, 0x2e)) goto l_0x100a_42a2; /* jz 0x100a42a2 */
            ii(0x100a_4274, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_4277, 5); calld(0x1007_63d4, -0x2_dea8);          /* call 0x100763d4 */
            ii(0x100a_427c, 5); calld(0x100a_9d1a, 0x5a99);             /* call 0x100a9d1a */
            ii(0x100a_4281, 3); movsx(ebx, al);                         /* movsx ebx, al */
            ii(0x100a_4284, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_4287, 5); calld(0x1007_63d4, -0x2_deb8);          /* call 0x100763d4 */
            ii(0x100a_428c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_428e, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_4291, 5); calld(0x1007_63a0, -0x2_def6);          /* call 0x100763a0 */
            ii(0x100a_4296, 5); calld(0x1015_26ac, 0xa_e411);           /* call 0x101526ac */
            ii(0x100a_429b, 5); calld(0x100a_3671, -0xc2f);             /* call 0x100a3671 */
            ii(0x100a_42a0, 2); jmpd(0x100a_42c3, 0x21); goto l_0x100a_42c3; /* jmp 0x100a42c3 */
        l_0x100a_42a2:
            ii(0x100a_42a2, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_42a5, 5); calld(0x1007_63d4, -0x2_ded6);          /* call 0x100763d4 */
            ii(0x100a_42aa, 5); calld(0x100a_9d1a, 0x5a6b);             /* call 0x100a9d1a */
            ii(0x100a_42af, 3); movsx(ebx, al);                         /* movsx ebx, al */
            ii(0x100a_42b2, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_42b5, 5); calld(0x1007_63d4, -0x2_dee6);          /* call 0x100763d4 */
            ii(0x100a_42ba, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_42bc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_42be, 5); calld(0x100a_346a, -0xe59);             /* call 0x100a346a */
        l_0x100a_42c3:
            ii(0x100a_42c3, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_42c6, 5); calld(0x1008_ab8c, -0x1_973f);          /* call 0x1008ab8c */
            ii(0x100a_42cb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_42cd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_42d0, 3); add(eax, 0x28);                         /* add eax, 0x28 */
            ii(0x100a_42d3, 5); calld(0x1008_aaec, -0x1_97ec);          /* call 0x1008aaec */
            ii(0x100a_42d8, 5); calld(0x1014_82f4, 0xa_4017);           /* call 0x101482f4 */
            ii(0x100a_42dd, 6); sub(eax, memd_a32[ds, 0x101c_3974]);    /* sub eax, [0x101c3974] */
            ii(0x100a_42e3, 6); cmp(eax, memd_a32[ds, 0x101b_dd84]);    /* cmp eax, [0x101bdd84] */
            ii(0x100a_42e9, 2); if(jbed(0x100a_430a, 0x1f)) goto l_0x100a_430a; /* jbe 0x100a430a */
            ii(0x100a_42eb, 9); mov(memw_a32[ds, 0x101c_31c0], 0x1);    /* mov word [0x101c31c0], 0x1 */
            ii(0x100a_42f4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_42f6, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_42f9, 5); calld(0x1007_5f6c, -0x2_e392);          /* call 0x10075f6c */
            ii(0x100a_42fe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4300, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_4303, 5); calld(0x1008_8bbc, -0x1_b74c);          /* call 0x10088bbc */
            ii(0x100a_4308, 2); jmpd(0x100a_4323, 0x19); goto l_0x100a_4323; /* jmp 0x100a4323 */
        l_0x100a_430a:
            ii(0x100a_430a, 5); jmpd(0x100a_41b6, -0x159); goto l_0x100a_41b6; /* jmp 0x100a41b6 */
        l_0x100a_430f:
            ii(0x100a_430f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4311, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_4314, 5); calld(0x1007_5f6c, -0x2_e3ad);          /* call 0x10075f6c */
        l_0x100a_4319:
            ii(0x100a_4319, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_431b, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_431e, 5); calld(0x1008_8bbc, -0x1_b767);          /* call 0x10088bbc */
        l_0x100a_4323:
            ii(0x100a_4323, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_4325, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_4326, 1); popd(edi);                              /* pop edi */
            ii(0x100a_4327, 1); popd(esi);                              /* pop esi */
            ii(0x100a_4328, 1); popd(edx);                              /* pop edx */
            ii(0x100a_4329, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_432a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_432b, 1); retd();                                 /* ret */
        }
    }
}

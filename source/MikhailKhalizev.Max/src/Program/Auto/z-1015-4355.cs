using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_4355-ad608694")]
        public void Method_1015_4355()
        {
            ii(0x1015_4355, 5); pushd(0x54);                            /* push 0x54 */
            ii(0x1015_435a, 5); calld(Definitions.sys_check_available_stack_size, 0x1_19f3); /* call 0x10165d52 */
            ii(0x1015_435f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_4360, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_4361, 1); pushd(edx);                             /* push edx */
            ii(0x1015_4362, 1); pushd(esi);                             /* push esi */
            ii(0x1015_4363, 1); pushd(edi);                             /* push edi */
            ii(0x1015_4364, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_4365, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_4367, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1015_436d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_4370, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_4372, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_4375, 3); mov(al, memb_a32[ds, edx + 0x29]);      /* mov al, [edx+0x29] */
            ii(0x1015_4378, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_437b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_437d, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1015_4382, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_4385, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4388, 5); calld(0x1007_6074, -0xd_e319);          /* call 0x10076074 */
            ii(0x1015_438d, 2); test(al, al);                           /* test al, al */
            ii(0x1015_438f, 2); if(jnzd(0x1015_439a, 0x9)) goto l_0x1015_439a; /* jnz 0x1015439a */
            ii(0x1015_4391, 7); cmp(memb_a32[ds, 0x101c_3980], 0);      /* cmp byte [0x101c3980], 0x0 */
            ii(0x1015_4398, 2); if(jzd(0x1015_43a0, 0x6)) goto l_0x1015_43a0; /* jz 0x101543a0 */
        l_0x1015_439a:
            ii(0x1015_439a, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1015_439e, 2); jmpd(0x1015_43a4, 0x4); goto l_0x1015_43a4; /* jmp 0x101543a4 */
        l_0x1015_43a0:
            ii(0x1015_43a0, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1015_43a4:
            ii(0x1015_43a4, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1015_43a7, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1015_43aa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_43ad, 4); mov(memb_a32[ds, eax + 0x58], 0x3);     /* mov byte [eax+0x58], 0x3 */
            ii(0x1015_43b1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_43b4, 5); cmp(memw_a32[ds, eax + 0x8], 0x23);     /* cmp word [eax+0x8], 0x23 */
            ii(0x1015_43b9, 2); if(jnzd(0x1015_43cd, 0x12)) goto l_0x1015_43cd; /* jnz 0x101543cd */
            ii(0x1015_43bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_43be, 3); mov(al, memb_a32[ds, eax + 0x58]);      /* mov al, [eax+0x58] */
            ii(0x1015_43c1, 2); mov(ah, 0x5);                           /* mov ah, 0x5 */
            ii(0x1015_43c3, 2); mul(ah);                                /* mul ah */
            ii(0x1015_43c5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_43c8, 3); mov(memb_a32[ds, edx + 0x58], al);      /* mov [edx+0x58], al */
            ii(0x1015_43cb, 2); jmpd(0x1015_43e7, 0x1a); goto l_0x1015_43e7; /* jmp 0x101543e7 */
        l_0x1015_43cd:
            ii(0x1015_43cd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_43d0, 5); cmp(memw_a32[ds, eax + 0x8], 0x37);     /* cmp word [eax+0x8], 0x37 */
            ii(0x1015_43d5, 2); if(jzd(0x1015_43e1, 0xa)) goto l_0x1015_43e1; /* jz 0x101543e1 */
            ii(0x1015_43d7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_43da, 5); cmp(memw_a32[ds, eax + 0x8], 0x44);     /* cmp word [eax+0x8], 0x44 */
            ii(0x1015_43df, 2); if(jnzd(0x1015_43e7, 0x6)) goto l_0x1015_43e7; /* jnz 0x101543e7 */
        l_0x1015_43e1:
            ii(0x1015_43e1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_43e4, 3); shl(memb_a32[ds, eax + 0x58], 0x1);     /* shl byte [eax+0x58], 1 */
        l_0x1015_43e7:
            ii(0x1015_43e7, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1015_43eb, 2); if(jnzd(0x1015_442c, 0x3f)) goto l_0x1015_442c; /* jnz 0x1015442c */
            ii(0x1015_43ed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_43f0, 3); mov(edx, memd_a32[ds, eax + 0x41]);     /* mov edx, [eax+0x41] */
            ii(0x1015_43f3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_43f6, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1015_43fb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_43fe, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1015_4401, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4404, 3); mov(eax, memd_a32[ds, eax + 0x3f]);     /* mov eax, [eax+0x3f] */
            ii(0x1015_4407, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_440a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1015_440c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_440e, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1015_4413, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_4419, 6); mov(eax, memd_a32[ds, eax + 0x101c_a6a3]); /* mov eax, [eax+0x101ca6a3] */
            ii(0x1015_441f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_4421, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1015_4423, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_4428, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_442a, 2); if(jzd(0x1015_4447, 0x1b)) goto l_0x1015_4447; /* jz 0x10154447 */
        l_0x1015_442c:
            ii(0x1015_442c, 5); calld(0x1010_2bf8, -0x5_1839);          /* call 0x10102bf8 */
            ii(0x1015_4431, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_4433, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1015_4435, 5); mov(ebx, 0xc);                          /* mov ebx, 0xc */
            ii(0x1015_443a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_443d, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_4442, 5); calld(0x1013_d5c0, -0x1_6e87);          /* call 0x1013d5c0 */
        l_0x1015_4447:
            ii(0x1015_4447, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_444a, 4); test(memb_a32[ds, eax + 0x14], 0x2);    /* test byte [eax+0x14], 0x2 */
            ii(0x1015_444e, 6); if(jzd(0x1015_44eb, 0x97)) goto l_0x1015_44eb; /* jz 0x101544eb */
            ii(0x1015_4454, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4457, 4); test(memb_a32[ds, eax + 0x15], 0x2);    /* test byte [eax+0x15], 0x2 */
            ii(0x1015_445b, 2); if(jzd(0x1015_447e, 0x21)) goto l_0x1015_447e; /* jz 0x1015447e */
            ii(0x1015_445d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4460, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_4462, 3); mov(dl, memb_a32[ds, eax + 0x2e]);      /* mov dl, [eax+0x2e] */
            ii(0x1015_4465, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4468, 4); mov(ax, memw_a32[ds, eax + 0x37]);      /* mov ax, [eax+0x37] */
            ii(0x1015_446c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_446e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_4471, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4474, 5); calld(0x1014_9b9b, -0xa8de);            /* call 0x10149b9b */
            ii(0x1015_4479, 5); jmpd(0x1015_44eb, 0x6d); goto l_0x1015_44eb; /* jmp 0x101544eb */
        l_0x1015_447e:
            ii(0x1015_447e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4481, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1015_4486, 2); if(jzd(0x1015_4492, 0xa)) goto l_0x1015_4492; /* jz 0x10154492 */
            ii(0x1015_4488, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_448b, 5); cmp(memw_a32[ds, eax + 0x8], 0x43);     /* cmp word [eax+0x8], 0x43 */
            ii(0x1015_4490, 2); if(jnzd(0x1015_44d4, 0x42)) goto l_0x1015_44d4; /* jnz 0x101544d4 */
        l_0x1015_4492:
            ii(0x1015_4492, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4495, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1015_449a, 2); if(jnzd(0x1015_44b8, 0x1c)) goto l_0x1015_44b8; /* jnz 0x101544b8 */
            ii(0x1015_449c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_449f, 4); mov(memb_a32[ds, eax + 0x58], 0x8);     /* mov byte [eax+0x58], 0x8 */
            ii(0x1015_44a3, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_44a6, 5); add(eax, 0x68);                         /* add eax, 0x68 */
            ii(0x1015_44ab, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_44ae, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_44b1, 5); calld(0x1014_9b07, -0xa9af);            /* call 0x10149b07 */
            ii(0x1015_44b6, 2); jmpd(0x1015_44d2, 0x1a); goto l_0x1015_44d2; /* jmp 0x101544d2 */
        l_0x1015_44b8:
            ii(0x1015_44b8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_44bb, 4); mov(memb_a32[ds, eax + 0x58], 0x8);     /* mov byte [eax+0x58], 0x8 */
            ii(0x1015_44bf, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_44c2, 5); add(eax, 0x68);                         /* add eax, 0x68 */
            ii(0x1015_44c7, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_44ca, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_44cd, 5); calld(0x1014_9b07, -0xa9cb);            /* call 0x10149b07 */
        l_0x1015_44d2:
            ii(0x1015_44d2, 2); jmpd(0x1015_44eb, 0x17); goto l_0x1015_44eb; /* jmp 0x101544eb */
        l_0x1015_44d4:
            ii(0x1015_44d4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_44d7, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1015_44da, 4); add(dx, memw_a32[ds, eax + 0x37]);      /* add dx, [eax+0x37] */
            ii(0x1015_44de, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_44e0, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_44e3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_44e6, 5); calld(0x1014_9b07, -0xa9e4);            /* call 0x10149b07 */
        l_0x1015_44eb:
            ii(0x1015_44eb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_44ee, 4); test(memb_a32[ds, eax + 0x14], 0x4);    /* test byte [eax+0x14], 0x4 */
            ii(0x1015_44f2, 6); if(jzd(0x1015_4674, 0x17c)) goto l_0x1015_4674; /* jz 0x10154674 */
            ii(0x1015_44f8, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1015_44fc, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_44ff, 5); calld(Definitions.my_ctor_0x101b_38f8, -0xd_de14); /* call 0x100766f0 */
            ii(0x1015_4504, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1015_4507, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1015_450b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_450e, 5); cmp(memw_a32[ds, eax + 0x8], 0x47);     /* cmp word [eax+0x8], 0x47 */
            ii(0x1015_4513, 2); if(jzd(0x1015_451f, 0xa)) goto l_0x1015_451f; /* jz 0x1015451f */
            ii(0x1015_4515, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4518, 5); cmp(memw_a32[ds, eax + 0x8], 0x45);     /* cmp word [eax+0x8], 0x45 */
            ii(0x1015_451d, 2); if(jnzd(0x1015_4528, 0x9)) goto l_0x1015_4528; /* jnz 0x10154528 */
        l_0x1015_451f:
            ii(0x1015_451f, 7); mov(memd_a32[ss, ebp - 0x20], 0x55);    /* mov dword [ebp-0x20], 0x55 */
            ii(0x1015_4526, 2); jmpd(0x1015_4572, 0x4a); goto l_0x1015_4572; /* jmp 0x10154572 */
        l_0x1015_4528:
            ii(0x1015_4528, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_452b, 5); cmp(memw_a32[ds, eax + 0x8], 0x51);     /* cmp word [eax+0x8], 0x51 */
            ii(0x1015_4530, 2); if(jnzd(0x1015_453b, 0x9)) goto l_0x1015_453b; /* jnz 0x1015453b */
            ii(0x1015_4532, 7); mov(memd_a32[ss, ebp - 0x20], 0x57);    /* mov dword [ebp-0x20], 0x57 */
            ii(0x1015_4539, 2); jmpd(0x1015_4572, 0x37); goto l_0x1015_4572; /* jmp 0x10154572 */
        l_0x1015_453b:
            ii(0x1015_453b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_453e, 5); cmp(memw_a32[ds, eax + 0x8], 0x52);     /* cmp word [eax+0x8], 0x52 */
            ii(0x1015_4543, 2); if(jzd(0x1015_454f, 0xa)) goto l_0x1015_454f; /* jz 0x1015454f */
            ii(0x1015_4545, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4548, 5); cmp(memw_a32[ds, eax + 0x8], 0x50);     /* cmp word [eax+0x8], 0x50 */
            ii(0x1015_454d, 2); if(jnzd(0x1015_4558, 0x9)) goto l_0x1015_4558; /* jnz 0x10154558 */
        l_0x1015_454f:
            ii(0x1015_454f, 7); mov(memd_a32[ss, ebp - 0x20], 0x58);    /* mov dword [ebp-0x20], 0x58 */
            ii(0x1015_4556, 2); jmpd(0x1015_4572, 0x1a); goto l_0x1015_4572; /* jmp 0x10154572 */
        l_0x1015_4558:
            ii(0x1015_4558, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_455b, 5); cmp(memw_a32[ds, eax + 0x8], 0x53);     /* cmp word [eax+0x8], 0x53 */
            ii(0x1015_4560, 2); if(jnzd(0x1015_456b, 0x9)) goto l_0x1015_456b; /* jnz 0x1015456b */
            ii(0x1015_4562, 7); mov(memd_a32[ss, ebp - 0x20], 0x56);    /* mov dword [ebp-0x20], 0x56 */
            ii(0x1015_4569, 2); jmpd(0x1015_4572, 0x7); goto l_0x1015_4572; /* jmp 0x10154572 */
        l_0x1015_456b:
            ii(0x1015_456b, 7); mov(memd_a32[ss, ebp - 0x20], 0x54);    /* mov dword [ebp-0x20], 0x54 */
        l_0x1015_4572:
            ii(0x1015_4572, 5); cmp(memw_a32[ss, ebp - 0x20], 0x57);    /* cmp word [ebp-0x20], 0x57 */
            ii(0x1015_4577, 2); if(jzd(0x1015_4580, 0x7)) goto l_0x1015_4580; /* jz 0x10154580 */
            ii(0x1015_4579, 5); cmp(memw_a32[ss, ebp - 0x20], 0x58);    /* cmp word [ebp-0x20], 0x58 */
            ii(0x1015_457e, 2); if(jnzd(0x1015_4589, 0x9)) goto l_0x1015_4589; /* jnz 0x10154589 */
        l_0x1015_4580:
            ii(0x1015_4580, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1015_4587, 2); jmpd(0x1015_45bd, 0x34); goto l_0x1015_45bd; /* jmp 0x101545bd */
        l_0x1015_4589:
            ii(0x1015_4589, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_458c, 4); mov(ax, memw_a32[ds, eax + 0x43]);      /* mov ax, [eax+0x43] */
            ii(0x1015_4590, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_4593, 4); sub(ax, memw_a32[ds, edx + 0x1c]);      /* sub ax, [edx+0x1c] */
            ii(0x1015_4597, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_459a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_459d, 4); mov(ax, memw_a32[ds, eax + 0x41]);      /* mov ax, [eax+0x41] */
            ii(0x1015_45a1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_45a4, 4); sub(ax, memw_a32[ds, edx + 0x1a]);      /* sub ax, [edx+0x1a] */
            ii(0x1015_45a8, 1); cwde();                                 /* cwde */
            ii(0x1015_45a9, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1015_45ab, 5); calld(0x1015_c4db, 0x7f2b);             /* call 0x1015c4db */
            ii(0x1015_45b0, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_45b3, 5); cmp(memw_a32[ss, ebp - 0x20], 0x56);    /* cmp word [ebp-0x20], 0x56 */
            ii(0x1015_45b8, 2); if(jnzd(0x1015_45bd, 0x3)) goto l_0x1015_45bd; /* jnz 0x101545bd */
            ii(0x1015_45ba, 3); shl(memd_a32[ss, ebp - 0x14], 0x1);     /* shl dword [ebp-0x14], 1 */
        l_0x1015_45bd:
            ii(0x1015_45bd, 5); calld(0x1010_2b84, -0x5_1a3e);          /* call 0x10102b84 */
            ii(0x1015_45c2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_45c7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_45c8, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_45cd, 1); pushd(eax);                             /* push eax */
            ii(0x1015_45ce, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_45d2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_45d3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_45d6, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1015_45d9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_45dc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_45dd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_45e0, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1015_45e3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_45e6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_45e7, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_45e9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_45ec, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_45ee, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x1015_45f1, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_45f4, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1015_45f8, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_45fb, 5); calld(0x1015_a2da, 0x5cda);             /* call 0x1015a2da */
            ii(0x1015_4600, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_4602, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_4605, 5); calld(0x1008_ac18, -0xc_99f2);          /* call 0x1008ac18 */
            ii(0x1015_460a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_460c, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_460f, 5); calld(0x1007_5f2c, -0xd_e6e8);          /* call 0x10075f2c */
            ii(0x1015_4614, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_4617, 5); calld(0x1007_6574, -0xd_e0a8);          /* call 0x10076574 */
            ii(0x1015_461c, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_461f, 4); mov(dx, memw_a32[ds, edx + 0x41]);      /* mov dx, [edx+0x41] */
            ii(0x1015_4623, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x1015_4627, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_462a, 5); calld(0x1007_6574, -0xd_e0bb);          /* call 0x10076574 */
            ii(0x1015_462f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_4632, 4); mov(dx, memw_a32[ds, edx + 0x43]);      /* mov dx, [edx+0x43] */
            ii(0x1015_4636, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
            ii(0x1015_463a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_463d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_4640, 5); calld(0x1007_6574, -0xd_e0d1);          /* call 0x10076574 */
            ii(0x1015_4645, 5); calld(0x1008_a998, -0xc_9cb2);          /* call 0x1008a998 */
            ii(0x1015_464a, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_464d, 5); calld(0x1007_6574, -0xd_e0de);          /* call 0x10076574 */
            ii(0x1015_4652, 4); mov(memb_a32[ds, eax + 0x3d], 0x2);     /* mov byte [eax+0x3d], 0x2 */
            ii(0x1015_4656, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_4659, 5); calld(0x1007_6574, -0xd_e0ea);          /* call 0x10076574 */
            ii(0x1015_465e, 4); mov(memb_a32[ds, eax + 0x3e], 0);       /* mov byte [eax+0x3e], 0x0 */
            ii(0x1015_4662, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4665, 5); calld(0x1015_c802, 0x8198);             /* call 0x1015c802 */
            ii(0x1015_466a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_466c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_466f, 5); calld(0x1007_5f2c, -0xd_e748);          /* call 0x10075f2c */
        l_0x1015_4674:
            ii(0x1015_4674, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4677, 3); dec(memb_a32[ds, eax + 0x54]);          /* dec byte [eax+0x54] */
            ii(0x1015_467a, 7); cmp(memb_a32[ds, 0x101c_3915], 0);      /* cmp byte [0x101c3915], 0x0 */
            ii(0x1015_4681, 2); if(jnzd(0x1015_46a4, 0x21)) goto l_0x1015_46a4; /* jnz 0x101546a4 */
            ii(0x1015_4683, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4686, 3); dec(memb_a32[ds, eax + 0x50]);          /* dec byte [eax+0x50] */
            ii(0x1015_4689, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_468c, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_468f, 5); calld(0x1007_6730, -0xd_df64);          /* call 0x10076730 */
            ii(0x1015_4694, 4); cmp(memb_a32[ds, eax + 0x16], 0);       /* cmp byte [eax+0x16], 0x0 */
            ii(0x1015_4698, 2); if(jnzd(0x1015_46a2, 0x8)) goto l_0x1015_46a2; /* jnz 0x101546a2 */
            ii(0x1015_469a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_469d, 5); calld(0x1015_429e, -0x404);             /* call 0x1015429e */
        l_0x1015_46a2:
            ii(0x1015_46a2, 2); jmpd(0x1015_46be, 0x1a); goto l_0x1015_46be; /* jmp 0x101546be */
        l_0x1015_46a4:
            ii(0x1015_46a4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_46a7, 3); mov(dl, memb_a32[ds, eax + 0x50]);      /* mov dl, [eax+0x50] */
            ii(0x1015_46aa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_46ad, 3); cmp(dl, memb_a32[ds, eax + 0x54]);      /* cmp dl, [eax+0x54] */
            ii(0x1015_46b0, 2); if(jbed(0x1015_46be, 0xc)) goto l_0x1015_46be; /* jbe 0x101546be */
            ii(0x1015_46b2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_46b5, 3); mov(dl, memb_a32[ds, eax + 0x54]);      /* mov dl, [eax+0x54] */
            ii(0x1015_46b8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_46bb, 3); mov(memb_a32[ds, eax + 0x50], dl);      /* mov [eax+0x50], dl */
        l_0x1015_46be:
            ii(0x1015_46be, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_46c1, 4); mov(memb_a32[ds, eax + 0x3e], 0x9);     /* mov byte [eax+0x3e], 0x9 */
            ii(0x1015_46c5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_46c7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_46c8, 1); popd(edi);                              /* pop edi */
            ii(0x1015_46c9, 1); popd(esi);                              /* pop esi */
            ii(0x1015_46ca, 1); popd(edx);                              /* pop edx */
            ii(0x1015_46cb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_46cc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_46cd, 1); retd(); return;                         /* ret */
        }
    }
}

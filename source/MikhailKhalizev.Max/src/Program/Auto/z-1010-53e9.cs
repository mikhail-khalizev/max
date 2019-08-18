using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2cee5bea-d69f-4ea8-94be-d581ff820e3e")]
        public void Method_1010_53e9()
        {
            ii(0x1010_53e9, 5); pushd(0x54);                            /* push 0x54 */
            ii(0x1010_53ee, 5); calld(Definitions.sys_check_available_stack_size, 0x6_095f); /* call 0x10165d52 */
            ii(0x1010_53f3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_53f4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_53f5, 1); pushd(esi);                             /* push esi */
            ii(0x1010_53f6, 1); pushd(edi);                             /* push edi */
            ii(0x1010_53f7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_53f8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_53fa, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1010_5400, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_5403, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_5406, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5409, 7); cmp(memd_a32[ds, eax + 0x46c], 0);      /* cmp dword [eax+0x46c], 0x0 */
            ii(0x1010_5410, 2); if(jzd(0x1010_542a, 0x18)) goto l_0x1010_542a; /* jz 0x1010542a */
            ii(0x1010_5412, 5); mov(edx, 0x101b_5c10);                  /* mov edx, 0x101b5c10 */
            ii(0x1010_5417, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_541a, 6); mov(eax, memd_a32[ds, eax + 0x46c]);    /* mov eax, [eax+0x46c] */
            ii(0x1010_5420, 5); calld(Definitions.sys_call_dtor_arr, 0x6_0b93); /* call 0x10165fb8 */
            ii(0x1010_5425, 5); calld(Definitions.sys_delete_arr, 0x6_0bae); /* call 0x10165fd8 */
        l_0x1010_542a:
            ii(0x1010_542a, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1010_542f, 5); calld(/* sys */ 0x1016_a24c, 0x6_4e18); /* call 0x1016a24c */
            ii(0x1010_5434, 6); calld_abs(memd_a32[ds, 0x101b_ddf0]);   /* call dword [0x101bddf0] */
            ii(0x1010_543a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_543c, 5); mov(eax, 0xa0);                         /* mov eax, 0xa0 */
            ii(0x1010_5441, 5); mov(edx, 0xa0);                         /* mov edx, 0xa0 */
            ii(0x1010_5446, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_5449, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_544b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_544d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5450, 7); mov(memw_a32[ds, eax + 0x466], dx);     /* mov [eax+0x466], dx */
            ii(0x1010_5457, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x1010_545a, 6); add(ecx, 0x468);                        /* add ecx, 0x468 */
            ii(0x1010_5460, 5); mov(ebx, 0x109);                        /* mov ebx, 0x109 */
            ii(0x1010_5465, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5468, 8); imul(ax, memw_a32[ds, eax + 0x466], 0xa); /* imul ax, [eax+0x466], 0xa */
            ii(0x1010_5470, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1010_5473, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_5476, 5); calld(0x100e_969d, -0x1_bdde);          /* call 0x100e969d */
            ii(0x1010_547b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_547d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5480, 6); mov(memd_a32[ds, eax + 0x46c], edx);    /* mov [eax+0x46c], edx */
            ii(0x1010_5486, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5489, 7); mov(dx, memw_a32[ds, eax + 0x468]);     /* mov dx, [eax+0x468] */
            ii(0x1010_5490, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5493, 7); cmp(dx, memw_a32[ds, eax + 0x466]);     /* cmp dx, [eax+0x466] */
            ii(0x1010_549a, 2); if(jgd(0x1010_54a5, 0x9)) goto l_0x1010_54a5; /* jg 0x101054a5 */
            ii(0x1010_549c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_549f, 4); cmp(memd_a32[ds, eax + 0x3b], 0);       /* cmp dword [eax+0x3b], 0x0 */
            ii(0x1010_54a3, 2); if(jnzd(0x1010_54a7, 0x2)) goto l_0x1010_54a7; /* jnz 0x101054a7 */
        l_0x1010_54a5:
            ii(0x1010_54a5, 2); jmpd(0x1010_550f, 0x68); goto l_0x1010_550f; /* jmp 0x1010550f */
        l_0x1010_54a7:
            ii(0x1010_54a7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_54aa, 3); mov(eax, memd_a32[ds, eax + 0x3b]);     /* mov eax, [eax+0x3b] */
            ii(0x1010_54ad, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_54b0, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1010_54b4, 2); if(jzd(0x1010_54ca, 0x14)) goto l_0x1010_54ca; /* jz 0x101054ca */
            ii(0x1010_54b6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_54b8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_54bb, 5); calld(Definitions.my_dtor_d2, -0x3_6f88); /* call 0x100ce538 */
            ii(0x1010_54c0, 5); calld(Definitions.sys_delete, 0x6_0a9f); /* call 0x10165f64 */
            ii(0x1010_54c5, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_54c8, 2); jmpd(0x1010_54d1, 0x7); goto l_0x1010_54d1; /* jmp 0x101054d1 */
        l_0x1010_54ca:
            ii(0x1010_54ca, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x1010_54d1:
            ii(0x1010_54d1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_54d4, 3); mov(eax, memd_a32[ds, eax + 0x3f]);     /* mov eax, [eax+0x3f] */
            ii(0x1010_54d7, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_54da, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1010_54de, 2); if(jzd(0x1010_54f4, 0x14)) goto l_0x1010_54f4; /* jz 0x101054f4 */
            ii(0x1010_54e0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_54e2, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_54e5, 5); calld(Definitions.my_dtor_d2, -0x3_6fb2); /* call 0x100ce538 */
            ii(0x1010_54ea, 5); calld(Definitions.sys_delete, 0x6_0a75); /* call 0x10165f64 */
            ii(0x1010_54ef, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1010_54f2, 2); jmpd(0x1010_54fb, 0x7); goto l_0x1010_54fb; /* jmp 0x101054fb */
        l_0x1010_54f4:
            ii(0x1010_54f4, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
        l_0x1010_54fb:
            ii(0x1010_54fb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_54fe, 7); mov(memd_a32[ds, eax + 0x3b], 0);       /* mov dword [eax+0x3b], 0x0 */
            ii(0x1010_5505, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5508, 7); mov(memd_a32[ds, eax + 0x3f], 0);       /* mov dword [eax+0x3f], 0x0 */
        l_0x1010_550f:
            ii(0x1010_550f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5512, 7); mov(dx, memw_a32[ds, eax + 0x468]);     /* mov dx, [eax+0x468] */
            ii(0x1010_5519, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_551c, 7); cmp(dx, memw_a32[ds, eax + 0x466]);     /* cmp dx, [eax+0x466] */
            ii(0x1010_5523, 2); if(jled(0x1010_552e, 0x9)) goto l_0x1010_552e; /* jle 0x1010552e */
            ii(0x1010_5525, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5528, 4); cmp(memd_a32[ds, eax + 0x3b], 0);       /* cmp dword [eax+0x3b], 0x0 */
            ii(0x1010_552c, 2); if(jzd(0x1010_5533, 0x5)) goto l_0x1010_5533; /* jz 0x10105533 */
        l_0x1010_552e:
            ii(0x1010_552e, 5); jmpd(0x1010_5645, 0x112); goto l_0x1010_5645; /* jmp 0x10105645 */
        l_0x1010_5533:
            ii(0x1010_5533, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1010_5538, 5); calld(Definitions.sys_new, 0x6_08c3);   /* call 0x10165e00 */
            ii(0x1010_553d, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1010_5540, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_5543, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1010_5546, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1010_554a, 2); if(jzd(0x1010_5574, 0x28)) goto l_0x1010_5574; /* jz 0x10105574 */
            ii(0x1010_554c, 5); mov(eax, 0xc5);                         /* mov eax, 0xc5 */
            ii(0x1010_5551, 1); pushd(eax);                             /* push eax */
            ii(0x1010_5552, 5); mov(ecx, 0x14);                         /* mov ecx, 0x14 */
            ii(0x1010_5557, 5); mov(ebx, 0x11b);                        /* mov ebx, 0x11b */
            ii(0x1010_555c, 5); mov(edx, 0x11a);                        /* mov edx, 0x11a */
            ii(0x1010_5561, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_5564, 5); calld(Definitions.my_ctor_c17, -0x3_715a); /* call 0x100ce40f */
            ii(0x1010_5569, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1010_556c, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1010_556f, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1010_5572, 2); jmpd(0x1010_557a, 0x6); goto l_0x1010_557a; /* jmp 0x1010557a */
        l_0x1010_5574:
            ii(0x1010_5574, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1010_5577, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x1010_557a:
            ii(0x1010_557a, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1010_557d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_5580, 3); mov(memd_a32[ds, edx + 0x3b], eax);     /* mov [edx+0x3b], eax */
            ii(0x1010_5583, 5); mov(edx, 0x3e9);                        /* mov edx, 0x3e9 */
            ii(0x1010_5588, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_558b, 3); mov(eax, memd_a32[ds, eax + 0x3b]);     /* mov eax, [eax+0x3b] */
            ii(0x1010_558e, 5); calld(0x100d_5134, -0x3_045f);          /* call 0x100d5134 */
            ii(0x1010_5593, 5); mov(edx, 0x73e9);                       /* mov edx, 0x73e9 */
            ii(0x1010_5598, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_559b, 3); mov(eax, memd_a32[ds, eax + 0x3b]);     /* mov eax, [eax+0x3b] */
            ii(0x1010_559e, 5); calld(0x100d_5164, -0x3_043f);          /* call 0x100d5164 */
            ii(0x1010_55a3, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x1010_55a8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_55ab, 3); mov(eax, memd_a32[ds, eax + 0x3b]);     /* mov eax, [eax+0x3b] */
            ii(0x1010_55ae, 5); calld(0x100d_50d4, -0x3_04df);          /* call 0x100d50d4 */
            ii(0x1010_55b3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_55b6, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x1010_55b9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_55bc, 3); mov(eax, memd_a32[ds, eax + 0x3b]);     /* mov eax, [eax+0x3b] */
            ii(0x1010_55bf, 5); calld(0x100c_f85c, -0x3_5d68);          /* call 0x100cf85c */
            ii(0x1010_55c4, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1010_55c9, 5); calld(Definitions.sys_new, 0x6_0832);   /* call 0x10165e00 */
            ii(0x1010_55ce, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1010_55d1, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1010_55d4, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1010_55d7, 4); cmp(memd_a32[ss, ebp - 0x30], 0);       /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1010_55db, 2); if(jzd(0x1010_5605, 0x28)) goto l_0x1010_5605; /* jz 0x10105605 */
            ii(0x1010_55dd, 5); mov(eax, 0xc5);                         /* mov eax, 0xc5 */
            ii(0x1010_55e2, 1); pushd(eax);                             /* push eax */
            ii(0x1010_55e3, 5); mov(ecx, 0x28);                         /* mov ecx, 0x28 */
            ii(0x1010_55e8, 5); mov(ebx, 0x11e);                        /* mov ebx, 0x11e */
            ii(0x1010_55ed, 5); mov(edx, 0x11d);                        /* mov edx, 0x11d */
            ii(0x1010_55f2, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1010_55f5, 5); calld(Definitions.my_ctor_c17, -0x3_71eb); /* call 0x100ce40f */
            ii(0x1010_55fa, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1010_55fd, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1010_5600, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1010_5603, 2); jmpd(0x1010_560b, 0x6); goto l_0x1010_560b; /* jmp 0x1010560b */
        l_0x1010_5605:
            ii(0x1010_5605, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1010_5608, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
        l_0x1010_560b:
            ii(0x1010_560b, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1010_560e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_5611, 3); mov(memd_a32[ds, edx + 0x3f], eax);     /* mov [edx+0x3f], eax */
            ii(0x1010_5614, 5); mov(edx, 0x3ea);                        /* mov edx, 0x3ea */
            ii(0x1010_5619, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_561c, 3); mov(eax, memd_a32[ds, eax + 0x3f]);     /* mov eax, [eax+0x3f] */
            ii(0x1010_561f, 5); calld(0x100d_5134, -0x3_04f0);          /* call 0x100d5134 */
            ii(0x1010_5624, 5); mov(edx, 0x73ea);                       /* mov edx, 0x73ea */
            ii(0x1010_5629, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_562c, 3); mov(eax, memd_a32[ds, eax + 0x3f]);     /* mov eax, [eax+0x3f] */
            ii(0x1010_562f, 5); calld(0x100d_5164, -0x3_04d0);          /* call 0x100d5164 */
            ii(0x1010_5634, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5637, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x1010_563a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_563d, 3); mov(eax, memd_a32[ds, eax + 0x3f]);     /* mov eax, [eax+0x3f] */
            ii(0x1010_5640, 5); calld(0x100c_f85c, -0x3_5de9);          /* call 0x100cf85c */
        l_0x1010_5645:
            ii(0x1010_5645, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5648, 5); calld(0x1010_5281, -0x3cc);             /* call 0x10105281 */
            ii(0x1010_564d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_564f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_5650, 1); popd(edi);                              /* pop edi */
            ii(0x1010_5651, 1); popd(esi);                              /* pop esi */
            ii(0x1010_5652, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_5653, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_5654, 1); retd(); return;                         /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_e188-35deefcf")]
        public void Method_100d_e188()
        {
            ii(0x100d_e188, 5); pushd(0x74);                            /* push 0x74 */
            ii(0x100d_e18d, 5); calld(Definitions.sys_check_available_stack_size, 0x8_7bc0); /* call 0x10165d52 */
            ii(0x100d_e192, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_e193, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_e194, 1); pushd(esi);                             /* push esi */
            ii(0x100d_e195, 1); pushd(edi);                             /* push edi */
            ii(0x100d_e196, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_e197, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_e199, 6); sub(esp, 0x5c);                         /* sub esp, 0x5c */
            ii(0x100d_e19f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_e1a2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_e1a5, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100d_e1ac, 2); if(jzd(0x100d_e1c5, 0x17)) goto l_0x100d_e1c5; /* jz 0x100de1c5 */
            ii(0x100d_e1ae, 5); mov(edx, 0x101b_5e3c);                  /* mov edx, 0x101b5e3c */
            ii(0x100d_e1b3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e1b6, 5); calld(Definitions.sys_call_dtor_arr, 0x8_7dfd); /* call 0x10165fb8 */
            ii(0x100d_e1bb, 5); calld(Definitions.sys_delete_arr, 0x8_7e18); /* call 0x10165fd8 */
            ii(0x100d_e1c0, 5); jmpd(0x100d_e3d8, 0x213); goto l_0x100d_e3d8; /* jmp 0x100de3d8 */
        l_0x100d_e1c5:
            ii(0x100d_e1c5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e1c8, 7); mov(memd_a32[ds, eax + 0x13], 0x101b_5ee0); /* mov dword [eax+0x13], 0x101b5ee0 */
            ii(0x100d_e1cf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e1d2, 6); mov(eax, memd_a32[ds, eax + 0x3bb]);    /* mov eax, [eax+0x3bb] */
            ii(0x100d_e1d8, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x100d_e1db, 4); cmp(memd_a32[ss, ebp - 0x58], 0);       /* cmp dword [ebp-0x58], 0x0 */
            ii(0x100d_e1df, 2); if(jzd(0x100d_e1fc, 0x1b)) goto l_0x100d_e1fc; /* jz 0x100de1fc */
            ii(0x100d_e1e1, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x100d_e1e4, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x100d_e1e7, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x100d_e1ea, 3); mov(ebx, memd_a32[ds, eax + 0x40]);     /* mov ebx, [eax+0x40] */
            ii(0x100d_e1ed, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100d_e1f2, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x100d_e1f5, 2); calld_abs(memd_a32[ds, ebx]);           /* call dword [ebx] */
            ii(0x100d_e1f7, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100d_e1fa, 2); jmpd(0x100d_e203, 0x7); goto l_0x100d_e203; /* jmp 0x100de203 */
        l_0x100d_e1fc:
            ii(0x100d_e1fc, 7); mov(memd_a32[ss, ebp - 0x30], 0);       /* mov dword [ebp-0x30], 0x0 */
        l_0x100d_e203:
            ii(0x100d_e203, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e206, 6); mov(eax, memd_a32[ds, eax + 0x3cb]);    /* mov eax, [eax+0x3cb] */
            ii(0x100d_e20c, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x100d_e20f, 4); cmp(memd_a32[ss, ebp - 0x54], 0);       /* cmp dword [ebp-0x54], 0x0 */
            ii(0x100d_e213, 2); if(jzd(0x100d_e229, 0x14)) goto l_0x100d_e229; /* jz 0x100de229 */
            ii(0x100d_e215, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_e217, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x100d_e21a, 5); calld(Definitions.my_dtor_d2, -0xfce7); /* call 0x100ce538 */
            ii(0x100d_e21f, 5); calld(Definitions.sys_delete, 0x8_7d40); /* call 0x10165f64 */
            ii(0x100d_e224, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100d_e227, 2); jmpd(0x100d_e230, 0x7); goto l_0x100d_e230; /* jmp 0x100de230 */
        l_0x100d_e229:
            ii(0x100d_e229, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
        l_0x100d_e230:
            ii(0x100d_e230, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e233, 6); mov(eax, memd_a32[ds, eax + 0x3cf]);    /* mov eax, [eax+0x3cf] */
            ii(0x100d_e239, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x100d_e23c, 4); cmp(memd_a32[ss, ebp - 0x50], 0);       /* cmp dword [ebp-0x50], 0x0 */
            ii(0x100d_e240, 2); if(jzd(0x100d_e256, 0x14)) goto l_0x100d_e256; /* jz 0x100de256 */
            ii(0x100d_e242, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_e244, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x100d_e247, 5); calld(Definitions.my_dtor_d2, -0xfd14); /* call 0x100ce538 */
            ii(0x100d_e24c, 5); calld(Definitions.sys_delete, 0x8_7d13); /* call 0x10165f64 */
            ii(0x100d_e251, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100d_e254, 2); jmpd(0x100d_e25d, 0x7); goto l_0x100d_e25d; /* jmp 0x100de25d */
        l_0x100d_e256:
            ii(0x100d_e256, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
        l_0x100d_e25d:
            ii(0x100d_e25d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e260, 6); mov(eax, memd_a32[ds, eax + 0x3c3]);    /* mov eax, [eax+0x3c3] */
            ii(0x100d_e266, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x100d_e269, 4); cmp(memd_a32[ss, ebp - 0x4c], 0);       /* cmp dword [ebp-0x4c], 0x0 */
            ii(0x100d_e26d, 2); if(jzd(0x100d_e283, 0x14)) goto l_0x100d_e283; /* jz 0x100de283 */
            ii(0x100d_e26f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_e271, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x100d_e274, 5); calld(Definitions.my_dtor_d2, -0xfd41); /* call 0x100ce538 */
            ii(0x100d_e279, 5); calld(Definitions.sys_delete, 0x8_7ce6); /* call 0x10165f64 */
            ii(0x100d_e27e, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100d_e281, 2); jmpd(0x100d_e28a, 0x7); goto l_0x100d_e28a; /* jmp 0x100de28a */
        l_0x100d_e283:
            ii(0x100d_e283, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
        l_0x100d_e28a:
            ii(0x100d_e28a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e28d, 6); mov(eax, memd_a32[ds, eax + 0x3c7]);    /* mov eax, [eax+0x3c7] */
            ii(0x100d_e293, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100d_e296, 4); cmp(memd_a32[ss, ebp - 0x48], 0);       /* cmp dword [ebp-0x48], 0x0 */
            ii(0x100d_e29a, 2); if(jzd(0x100d_e2b0, 0x14)) goto l_0x100d_e2b0; /* jz 0x100de2b0 */
            ii(0x100d_e29c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_e29e, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100d_e2a1, 5); calld(Definitions.my_dtor_d2, -0xfd6e); /* call 0x100ce538 */
            ii(0x100d_e2a6, 5); calld(Definitions.sys_delete, 0x8_7cb9); /* call 0x10165f64 */
            ii(0x100d_e2ab, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100d_e2ae, 2); jmpd(0x100d_e2b7, 0x7); goto l_0x100d_e2b7; /* jmp 0x100de2b7 */
        l_0x100d_e2b0:
            ii(0x100d_e2b0, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
        l_0x100d_e2b7:
            ii(0x100d_e2b7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e2ba, 6); mov(eax, memd_a32[ds, eax + 0x3d3]);    /* mov eax, [eax+0x3d3] */
            ii(0x100d_e2c0, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100d_e2c3, 4); cmp(memd_a32[ss, ebp - 0x44], 0);       /* cmp dword [ebp-0x44], 0x0 */
            ii(0x100d_e2c7, 2); if(jzd(0x100d_e2dd, 0x14)) goto l_0x100d_e2dd; /* jz 0x100de2dd */
            ii(0x100d_e2c9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_e2cb, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100d_e2ce, 5); calld(Definitions.my_dtor_d2, -0xfd9b); /* call 0x100ce538 */
            ii(0x100d_e2d3, 5); calld(Definitions.sys_delete, 0x8_7c8c); /* call 0x10165f64 */
            ii(0x100d_e2d8, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100d_e2db, 2); jmpd(0x100d_e2e4, 0x7); goto l_0x100d_e2e4; /* jmp 0x100de2e4 */
        l_0x100d_e2dd:
            ii(0x100d_e2dd, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
        l_0x100d_e2e4:
            ii(0x100d_e2e4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e2e7, 6); mov(eax, memd_a32[ds, eax + 0x3d7]);    /* mov eax, [eax+0x3d7] */
            ii(0x100d_e2ed, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100d_e2f0, 4); cmp(memd_a32[ss, ebp - 0x40], 0);       /* cmp dword [ebp-0x40], 0x0 */
            ii(0x100d_e2f4, 2); if(jzd(0x100d_e30a, 0x14)) goto l_0x100d_e30a; /* jz 0x100de30a */
            ii(0x100d_e2f6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_e2f8, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100d_e2fb, 5); calld(Definitions.my_dtor_d2, -0xfdc8); /* call 0x100ce538 */
            ii(0x100d_e300, 5); calld(Definitions.sys_delete, 0x8_7c5f); /* call 0x10165f64 */
            ii(0x100d_e305, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100d_e308, 2); jmpd(0x100d_e311, 0x7); goto l_0x100d_e311; /* jmp 0x100de311 */
        l_0x100d_e30a:
            ii(0x100d_e30a, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
        l_0x100d_e311:
            ii(0x100d_e311, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e314, 6); mov(eax, memd_a32[ds, eax + 0x3db]);    /* mov eax, [eax+0x3db] */
            ii(0x100d_e31a, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100d_e31d, 4); cmp(memd_a32[ss, ebp - 0x3c], 0);       /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x100d_e321, 2); if(jzd(0x100d_e337, 0x14)) goto l_0x100d_e337; /* jz 0x100de337 */
            ii(0x100d_e323, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_e325, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100d_e328, 5); calld(Definitions.my_dtor_d2, -0xfdf5); /* call 0x100ce538 */
            ii(0x100d_e32d, 5); calld(Definitions.sys_delete, 0x8_7c32); /* call 0x10165f64 */
            ii(0x100d_e332, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_e335, 2); jmpd(0x100d_e33e, 0x7); goto l_0x100d_e33e; /* jmp 0x100de33e */
        l_0x100d_e337:
            ii(0x100d_e337, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
        l_0x100d_e33e:
            ii(0x100d_e33e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e341, 6); mov(eax, memd_a32[ds, eax + 0x3df]);    /* mov eax, [eax+0x3df] */
            ii(0x100d_e347, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100d_e34a, 4); cmp(memd_a32[ss, ebp - 0x34], 0);       /* cmp dword [ebp-0x34], 0x0 */
            ii(0x100d_e34e, 2); if(jzd(0x100d_e36b, 0x1b)) goto l_0x100d_e36b; /* jz 0x100de36b */
            ii(0x100d_e350, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100d_e353, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100d_e356, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100d_e359, 3); mov(ebx, memd_a32[ds, eax + 0x27]);     /* mov ebx, [eax+0x27] */
            ii(0x100d_e35c, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100d_e361, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100d_e364, 2); calld_abs(memd_a32[ds, ebx]);           /* call dword [ebx] */
            ii(0x100d_e366, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_e369, 2); jmpd(0x100d_e372, 0x7); goto l_0x100d_e372; /* jmp 0x100de372 */
        l_0x100d_e36b:
            ii(0x100d_e36b, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x100d_e372:
            ii(0x100d_e372, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_e374, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e377, 5); add(eax, 0x3b7);                        /* add eax, 0x3b7 */
            ii(0x100d_e37c, 5); calld(0x100e_0244, 0x1ec3);             /* call 0x100e0244 */
            ii(0x100d_e381, 5); sub(eax, 0x3b7);                        /* sub eax, 0x3b7 */
            ii(0x100d_e386, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_e389, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_e38b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e38e, 5); add(eax, 0x3b3);                        /* add eax, 0x3b3 */
            ii(0x100d_e393, 5); calld(0x1008_8b04, -0x5_5894);          /* call 0x10088b04 */
            ii(0x100d_e398, 5); sub(eax, 0x3b3);                        /* sub eax, 0x3b3 */
            ii(0x100d_e39d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_e3a0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_e3a2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e3a5, 5); add(eax, 0x3af);                        /* add eax, 0x3af */
            ii(0x100d_e3aa, 5); calld(0x1008_8b04, -0x5_58ab);          /* call 0x10088b04 */
            ii(0x100d_e3af, 5); sub(eax, 0x3af);                        /* sub eax, 0x3af */
            ii(0x100d_e3b4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_e3b7, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_e3bc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e3bf, 5); calld(0x100d_9a4a, -0x497a);            /* call 0x100d9a4a */
            ii(0x100d_e3c4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_e3c7, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100d_e3ce, 2); if(jzd(0x100d_e3d8, 0x8)) goto l_0x100d_e3d8; /* jz 0x100de3d8 */
            ii(0x100d_e3d0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e3d3, 5); calld(Definitions.sys_delete, 0x8_7b8c); /* call 0x10165f64 */
        l_0x100d_e3d8:
            ii(0x100d_e3d8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e3db, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100d_e3de, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_e3e1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_e3e3, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_e3e4, 1); popd(edi);                              /* pop edi */
            ii(0x100d_e3e5, 1); popd(esi);                              /* pop esi */
            ii(0x100d_e3e6, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_e3e7, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_e3e8, 1); retd();                                 /* ret */
        }
    }
}

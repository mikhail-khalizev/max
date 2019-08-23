using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_1e00-65af926f")]
        public void Method_1011_1e00()
        {
            ii(0x1011_1e00, 5); push(0x68);                             /* push 0x68 */
            ii(0x1011_1e05, 5); call(Definitions.sys_check_available_stack_size, 0x5_3f48); /* call 0x10165d52 */
            ii(0x1011_1e0a, 1); push(ebx);                              /* push ebx */
            ii(0x1011_1e0b, 1); push(ecx);                              /* push ecx */
            ii(0x1011_1e0c, 1); push(edx);                              /* push edx */
            ii(0x1011_1e0d, 1); push(esi);                              /* push esi */
            ii(0x1011_1e0e, 1); push(edi);                              /* push edi */
            ii(0x1011_1e0f, 1); push(ebp);                              /* push ebp */
            ii(0x1011_1e10, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_1e12, 6); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x1011_1e18, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_1e1a, 5); call(0x100e_883d, -0x2_95e2);           /* call 0x100e883d */
            ii(0x1011_1e1f, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_1e22, 4); mov(memb[ss, ebp - 0x4], 0x1);          /* mov byte [ebp-0x4], 0x1 */
            ii(0x1011_1e26, 7); mov(memd[ss, ebp - 0x8], 0x1);          /* mov dword [ebp-0x8], 0x1 */
            ii(0x1011_1e2d, 5); mov(edx, 0xf0);                         /* mov edx, 0xf0 */
            ii(0x1011_1e32, 5); mov(eax, 0x140);                        /* mov eax, 0x140 */
            ii(0x1011_1e37, 5); call(/* sys */ 0x1016_c2bc, 0x5_a480);  /* call 0x1016c2bc */
            ii(0x1011_1e3c, 9); mov(memw[ds, 0x101c_4e4e], 0xffff);     /* mov word [0x101c4e4e], 0xffff */
            ii(0x1011_1e45, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_1e47, 5); call(/* sys */ 0x1017_8f78, 0x6_712c);  /* call 0x10178f78 */
            ii(0x1011_1e4c, 5); call(/* sys */ 0x1016_5ebf, 0x5_406e);  /* call 0x10165ebf */
            ii(0x1011_1e51, 5); mov(eax, 0x4a);                         /* mov eax, 0x4a */
            ii(0x1011_1e56, 5); call(0x1007_5fdc, -0x9_be7f);           /* call 0x10075fdc */
            ii(0x1011_1e5b, 6); mov(memw[ds, 0x101c_3966], ax);         /* mov [0x101c3966], ax */
            ii(0x1011_1e61, 5); mov(eax, 0x4b);                         /* mov eax, 0x4b */
            ii(0x1011_1e66, 5); call(0x1007_5fdc, -0x9_be8f);           /* call 0x10075fdc */
            ii(0x1011_1e6b, 6); mov(memw[ds, 0x101c_3968], ax);         /* mov [0x101c3968], ax */
        l_0x1011_1e71:
            ii(0x1011_1e71, 4); mov(memb[ss, ebp - 0x18], 0);           /* mov byte [ebp-0x18], 0x0 */
            ii(0x1011_1e75, 5); call(0x1014_82f4, 0x3_647a);            /* call 0x101482f4 */
            ii(0x1011_1e7a, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_1e7d, 7); mov(memb[ds, 0x101c_391e], 0x3);        /* mov byte [0x101c391e], 0x3 */
            ii(0x1011_1e84, 5); call(/* sys */ 0x1016_be34, 0x5_9fab);  /* call 0x1016be34 */
            ii(0x1011_1e89, 5); call(0x100d_533c, -0x3_cb52);           /* call 0x100d533c */
            ii(0x1011_1e8e, 1); cwde();                                 /* cwde */
            ii(0x1011_1e8f, 1); push(eax);                              /* push eax */
            ii(0x1011_1e90, 5); call(0x100d_5360, -0x3_cb35);           /* call 0x100d5360 */
            ii(0x1011_1e95, 1); cwde();                                 /* cwde */
            ii(0x1011_1e96, 1); push(eax);                              /* push eax */
            ii(0x1011_1e97, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_1e99, 1); push(eax);                              /* push eax */
            ii(0x1011_1e9a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_1e9c, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x1011_1e9f, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1011_1ea2, 5); mov(ebx, 0x280);                        /* mov ebx, 0x280 */
            ii(0x1011_1ea7, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1011_1eaa, 5); mov(eax, 0x6c0);                        /* mov eax, 0x6c0 */
            ii(0x1011_1eaf, 5); call(0x100e_8c51, -0x2_9263);           /* call 0x100e8c51 */
            ii(0x1011_1eb4, 5); mov(edx, StringDefinitions.MainMenu);   /* mov edx, 0x101a4714 */
            ii(0x1011_1eb9, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_1ebc, 5); call(0x1010_c628, -0x5899);             /* call 0x1010c628 */
            ii(0x1011_1ec1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_1ec3, 6); mov(edx, memd[ds, 0x101c_4e4c]);        /* mov edx, [0x101c4e4c] */
            ii(0x1011_1ec9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_1ecc, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_1ecf, 5); call(0x1010_c693, -0x5841);             /* call 0x1010c693 */
            ii(0x1011_1ed4, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_1ed7, 5); call(0x1011_1b05, -0x3d7);              /* call 0x10111b05 */
            ii(0x1011_1edc, 5); call(0x1011_52f4, 0x3413);              /* call 0x101152f4 */
            ii(0x1011_1ee1, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1011_1ee4, 5); mov(edx, 0x8);                          /* mov edx, 0x8 */
            ii(0x1011_1ee9, 5); mov(eax, 0x101b_901c);                  /* mov eax, 0x101b901c */
            ii(0x1011_1eee, 5); call(0x1010_9cee, -0x8205);             /* call 0x10109cee */
            ii(0x1011_1ef3, 5); call(/* sys */ 0x1016_bcc4, 0x5_9dcc);  /* call 0x1016bcc4 */
            ii(0x1011_1ef8, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_1efa, 5); mov(edx, 0x6a5);                        /* mov edx, 0x6a5 */
            ii(0x1011_1eff, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1011_1f04, 5); call(0x1013_cf8e, 0x2_b085);            /* call 0x1013cf8e */
            ii(0x1011_1f09, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1011_1f0e, 5); call(0x1012_0d94, 0xee81);              /* call 0x10120d94 */
            ii(0x1011_1f13, 5); call(/* sys */ 0x1016_bcc4, 0x5_9dac);  /* call 0x1016bcc4 */
            ii(0x1011_1f18, 4); mov(memb[ss, ebp - 0x4], 0);            /* mov byte [ebp-0x4], 0x0 */
            ii(0x1011_1f1c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_1f1e, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1011_1f23, 5); call(0x100c_aafc, -0x4_742c);           /* call 0x100caafc */
            ii(0x1011_1f28, 4); mov(memb[ss, ebp - 0x20], 0);           /* mov byte [ebp-0x20], 0x0 */
        l_0x1011_1f2c:
            ii(0x1011_1f2c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_1f2e, 3); mov(al, memb[ss, ebp - 0x20]);          /* mov al, [ebp-0x20] */
            ii(0x1011_1f31, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_1f33, 6); if(jnz(0x1011_2201, 0x2c8)) goto l_0x1011_2201; /* jnz 0x10112201 */
            ii(0x1011_1f39, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1011_1f3c, 5); call(0x1014_85ad, 0x3_666c);            /* call 0x101485ad */
            ii(0x1011_1f41, 5); cmp(eax, 0xea60);                       /* cmp eax, 0xea60 */
            ii(0x1011_1f46, 2); if(jbe(0x1011_1f8d, 0x45)) goto l_0x1011_1f8d; /* jbe 0x10111f8d */
            ii(0x1011_1f48, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_1f4b, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1011_1f4e, 5); call(0x1010_9b8a, -0x83c9);             /* call 0x10109b8a */
        l_0x1011_1f53:
            ii(0x1011_1f53, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_1f57, 5); call(0x1011_1b8c, -0x3d0);              /* call 0x10111b8c */
            ii(0x1011_1f5c, 3); mov(memb[ss, ebp - 0x4], al);           /* mov [ebp-0x4], al */
            ii(0x1011_1f5f, 3); inc(memd[ss, ebp - 0x8]);               /* inc dword [ebp-0x8] */
            ii(0x1011_1f62, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_1f66, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1011_1f69, 2); if(jle(0x1011_1f72, 0x7)) goto l_0x1011_1f72; /* jle 0x10111f72 */
            ii(0x1011_1f6b, 7); mov(memd[ss, ebp - 0x8], 0x1);          /* mov dword [ebp-0x8], 0x1 */
        l_0x1011_1f72:
            ii(0x1011_1f72, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_1f74, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x1011_1f77, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_1f79, 2); if(jnz(0x1011_1f84, 0x9)) goto l_0x1011_1f84; /* jnz 0x10111f84 */
            ii(0x1011_1f7b, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1011_1f7e, 4); cmp(ax, memw[ss, ebp - 0x8]);           /* cmp ax, [ebp-0x8] */
            ii(0x1011_1f82, 2); if(jnz(0x1011_1f86, 0x2)) goto l_0x1011_1f86; /* jnz 0x10111f86 */
        l_0x1011_1f84:
            ii(0x1011_1f84, 2); jmp(0x1011_1f88, 0x2); goto l_0x1011_1f88; /* jmp 0x10111f88 */
        l_0x1011_1f86:
            ii(0x1011_1f86, 2); jmp(0x1011_1f53, -0x35); goto l_0x1011_1f53; /* jmp 0x10111f53 */
        l_0x1011_1f88:
            ii(0x1011_1f88, 5); jmp(0x1011_2201, 0x274); goto l_0x1011_2201; /* jmp 0x10112201 */
        l_0x1011_1f8d:
            ii(0x1011_1f8d, 5); call(/* sys */ 0x1016_b208, 0x5_9276);  /* call 0x1016b208 */
            ii(0x1011_1f92, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1011_1f95, 3); lea(edx, memd[ss, ebp - 0x2c]);         /* lea edx, [ebp-0x2c] */
            ii(0x1011_1f98, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x1011_1f9b, 5); call(/* sys */ 0x1016_c298, 0x5_a2f8);  /* call 0x1016c298 */
            ii(0x1011_1fa0, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1011_1fa4, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1011_1fa7, 2); if(jnz(0x1011_1fb1, 0x8)) goto l_0x1011_1fb1; /* jnz 0x10111fb1 */
            ii(0x1011_1fa9, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1011_1fac, 3); cmp(eax, memd[ss, ebp - 0x10]);         /* cmp eax, [ebp-0x10] */
            ii(0x1011_1faf, 2); if(jz(0x1011_1fb3, 0x2)) goto l_0x1011_1fb3; /* jz 0x10111fb3 */
        l_0x1011_1fb1:
            ii(0x1011_1fb1, 2); jmp(0x1011_1fbb, 0x8); goto l_0x1011_1fbb; /* jmp 0x10111fbb */
        l_0x1011_1fb3:
            ii(0x1011_1fb3, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1011_1fb6, 3); cmp(eax, memd[ss, ebp - 0xc]);          /* cmp eax, [ebp-0xc] */
            ii(0x1011_1fb9, 2); if(jz(0x1011_1fcf, 0x14)) goto l_0x1011_1fcf; /* jz 0x10111fcf */
        l_0x1011_1fbb:
            ii(0x1011_1fbb, 5); call(0x1014_82f4, 0x3_6334);            /* call 0x101482f4 */
            ii(0x1011_1fc0, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_1fc3, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1011_1fc6, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_1fc9, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1011_1fcc, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
        l_0x1011_1fcf:
            ii(0x1011_1fcf, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1011_1fd3, 5); call(Definitions.sys_tolower, 0x6_0abd); /* call 0x10172a95 */
            ii(0x1011_1fd8, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1011_1fdb, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1011_1fdf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_1fe1, 2); if(jle(0x1011_1fee, 0xb)) goto l_0x1011_1fee; /* jle 0x10111fee */
            ii(0x1011_1fe3, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1011_1fe7, 5); cmp(eax, 0x7000);                       /* cmp eax, 0x7000 */
            ii(0x1011_1fec, 2); if(jl(0x1011_1ff0, 0x2)) goto l_0x1011_1ff0; /* jl 0x10111ff0 */
        l_0x1011_1fee:
            ii(0x1011_1fee, 2); jmp(0x1011_1ff4, 0x4); goto l_0x1011_1ff4; /* jmp 0x10111ff4 */
        l_0x1011_1ff0:
            ii(0x1011_1ff0, 4); mov(memb[ss, ebp - 0x18], 0);           /* mov byte [ebp-0x18], 0x0 */
        l_0x1011_1ff4:
            ii(0x1011_1ff4, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1011_1ff7, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1011_1ffa, 5); jmp(0x1011_2173, 0x174); goto l_0x1011_2173; /* jmp 0x10112173 */
        l_0x1011_1fff:
            ii(0x1011_1fff, 5); call(0x1010_9b8a, -0x847a);             /* call 0x10109b8a */
            ii(0x1011_2004, 5); call(0x1011_1745, -0x8c4);              /* call 0x10111745 */
            ii(0x1011_2009, 3); mov(memb[ss, ebp - 0x4], al);           /* mov [ebp-0x4], al */
            ii(0x1011_200c, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1011_2010, 2); if(jz(0x1011_201b, 0x9)) goto l_0x1011_201b; /* jz 0x1011201b */
            ii(0x1011_2012, 9); mov(memw[ds, 0x101c_4e4e], 0xffff);     /* mov word [0x101c4e4e], 0xffff */
        l_0x1011_201b:
            ii(0x1011_201b, 4); mov(memb[ss, ebp - 0x20], 0x1);         /* mov byte [ebp-0x20], 0x1 */
            ii(0x1011_201f, 5); jmp(0x1011_21fc, 0x1d8); goto l_0x1011_21fc; /* jmp 0x101121fc */
        l_0x1011_2024:
            ii(0x1011_2024, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1011_2028, 3); cmp(eax, 0xc);                          /* cmp eax, 0xc */
            ii(0x1011_202b, 2); if(jnz(0x1011_2033, 0x6)) goto l_0x1011_2033; /* jnz 0x10112033 */
            ii(0x1011_202d, 4); mov(memb[ss, ebp - 0x38], 0x1);         /* mov byte [ebp-0x38], 0x1 */
            ii(0x1011_2031, 2); jmp(0x1011_2037, 0x4); goto l_0x1011_2037; /* jmp 0x10112037 */
        l_0x1011_2033:
            ii(0x1011_2033, 4); mov(memb[ss, ebp - 0x38], 0);           /* mov byte [ebp-0x38], 0x0 */
        l_0x1011_2037:
            ii(0x1011_2037, 3); mov(al, memb[ss, ebp - 0x38]);          /* mov al, [ebp-0x38] */
            ii(0x1011_203a, 3); mov(memb[ss, ebp - 0x3c], al);          /* mov [ebp-0x3c], al */
            ii(0x1011_203d, 5); call(0x1010_9b8a, -0x84b8);             /* call 0x10109b8a */
            ii(0x1011_2042, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_2044, 3); mov(dl, memb[ss, ebp - 0x3c]);          /* mov dl, [ebp-0x3c] */
            ii(0x1011_2047, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_2049, 5); call(0x1013_843f, 0x2_63f1);            /* call 0x1013843f */
            ii(0x1011_204e, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1011_2051, 5); cmp(memw[ss, ebp - 0x28], 0);           /* cmp word [ebp-0x28], 0x0 */
            ii(0x1011_2056, 2); if(jz(0x1011_208e, 0x36)) goto l_0x1011_208e; /* jz 0x1011208e */
            ii(0x1011_2058, 4); cmp(memb[ss, ebp - 0x3c], 0);           /* cmp byte [ebp-0x3c], 0x0 */
            ii(0x1011_205c, 2); if(jz(0x1011_206d, 0xf)) goto l_0x1011_206d; /* jz 0x1011206d */
            ii(0x1011_205e, 5); mov(edx, 0x7);                          /* mov edx, 0x7 */
            ii(0x1011_2063, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1011_2068, 5); call(0x100c_aafc, -0x4_7571);           /* call 0x100caafc */
        l_0x1011_206d:
            ii(0x1011_206d, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1011_2071, 5); mov(eax, 0x3d);                         /* mov eax, 0x3d */
            ii(0x1011_2076, 5); call(0x100c_aafc, -0x4_757f);           /* call 0x100caafc */
            ii(0x1011_207b, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1011_2080, 5); call(0x100f_f0ba, -0x1_2fcb);           /* call 0x100ff0ba */
            ii(0x1011_2085, 9); mov(memw[ds, 0x101c_4e4e], 0xffff);     /* mov word [0x101c4e4e], 0xffff */
        l_0x1011_208e:
            ii(0x1011_208e, 4); mov(memb[ss, ebp - 0x4], 0x1);          /* mov byte [ebp-0x4], 0x1 */
            ii(0x1011_2092, 4); mov(memb[ss, ebp - 0x20], 0x1);         /* mov byte [ebp-0x20], 0x1 */
            ii(0x1011_2096, 5); jmp(0x1011_21fc, 0x161); goto l_0x1011_21fc; /* jmp 0x101121fc */
        l_0x1011_209b:
            ii(0x1011_209b, 5); call(0x1010_9b8a, -0x8516);             /* call 0x10109b8a */
            ii(0x1011_20a0, 5); call(0x1010_ff32, -0x2173);             /* call 0x1010ff32 */
            ii(0x1011_20a5, 3); mov(memb[ss, ebp - 0x4], al);           /* mov [ebp-0x4], al */
            ii(0x1011_20a8, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1011_20ac, 2); if(jz(0x1011_20b7, 0x9)) goto l_0x1011_20b7; /* jz 0x101120b7 */
            ii(0x1011_20ae, 9); mov(memw[ds, 0x101c_4e4e], 0xffff);     /* mov word [0x101c4e4e], 0xffff */
        l_0x1011_20b7:
            ii(0x1011_20b7, 4); mov(memb[ss, ebp - 0x20], 0x1);         /* mov byte [ebp-0x20], 0x1 */
            ii(0x1011_20bb, 5); jmp(0x1011_21fc, 0x13c); goto l_0x1011_21fc; /* jmp 0x101121fc */
        l_0x1011_20c0:
            ii(0x1011_20c0, 5); call(0x1010_9c90, -0x8435);             /* call 0x10109c90 */
            ii(0x1011_20c5, 5); call(0x1012_32e5, 0x1_121b);            /* call 0x101232e5 */
            ii(0x1011_20ca, 5); call(0x1010_9c29, -0x84a6);             /* call 0x10109c29 */
            ii(0x1011_20cf, 5); call(0x1014_82f4, 0x3_6220);            /* call 0x101482f4 */
            ii(0x1011_20d4, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_20d7, 5); jmp(0x1011_21fc, 0x120); goto l_0x1011_21fc; /* jmp 0x101121fc */
        l_0x1011_20dc:
            ii(0x1011_20dc, 5); call(/* sys */ 0x1016_be34, 0x5_9d53);  /* call 0x1016be34 */
            ii(0x1011_20e1, 5); call(0x1010_9b8a, -0x855c);             /* call 0x10109b8a */
            ii(0x1011_20e6, 5); call(Definitions.my_play_video_company, 0x3714); /* call 0x101157ff */
            ii(0x1011_20eb, 4); mov(memb[ss, ebp - 0x4], 0x1);          /* mov byte [ebp-0x4], 0x1 */
            ii(0x1011_20ef, 4); mov(memb[ss, ebp - 0x20], 0x1);         /* mov byte [ebp-0x20], 0x1 */
            ii(0x1011_20f3, 5); jmp(0x1011_21fc, 0x104); goto l_0x1011_21fc; /* jmp 0x101121fc */
        l_0x1011_20f8:
            ii(0x1011_20f8, 5); call(0x1010_9b8a, -0x8573);             /* call 0x10109b8a */
            ii(0x1011_20fd, 5); call(0x1010_c16c, -0x5f96);             /* call 0x1010c16c */
            ii(0x1011_2102, 4); mov(memb[ss, ebp - 0x4], 0x1);          /* mov byte [ebp-0x4], 0x1 */
            ii(0x1011_2106, 4); mov(memb[ss, ebp - 0x20], 0x1);         /* mov byte [ebp-0x20], 0x1 */
            ii(0x1011_210a, 5); jmp(0x1011_21fc, 0xed); goto l_0x1011_21fc; /* jmp 0x101121fc */
        l_0x1011_210f:
            ii(0x1011_210f, 5); call(0x1010_9b8a, -0x858a);             /* call 0x10109b8a */
            ii(0x1011_2114, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1011_2119, 5); call(0x100e_f3a0, -0x2_2d7e);           /* call 0x100ef3a0 */
        l_0x1011_211e:
            ii(0x1011_211e, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1011_2123, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1011_2128, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_212b, 5); call(0x1010_c693, -0x5a9d);             /* call 0x1010c693 */
            ii(0x1011_2130, 5); jmp(0x1011_21fc, 0xc7); goto l_0x1011_21fc; /* jmp 0x101121fc */
        l_0x1011_2135:
            ii(0x1011_2135, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1011_2139, 5); cmp(eax, 0x7000);                       /* cmp eax, 0x7000 */
            ii(0x1011_213e, 2); if(jl(0x1011_216e, 0x2e)) goto l_0x1011_216e; /* jl 0x1011216e */
            ii(0x1011_2140, 7); add(memd[ss, ebp - 0x28], 0xffff_9000); /* add dword [ebp-0x28], 0xffff9000 */
            ii(0x1011_2147, 4); cmp(memb[ss, ebp - 0x18], 0);           /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1011_214b, 2); if(jnz(0x1011_2156, 0x9)) goto l_0x1011_2156; /* jnz 0x10112156 */
            ii(0x1011_214d, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1011_2151, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1011_2154, 2); if(jb(0x1011_2158, 0x2)) goto l_0x1011_2158; /* jb 0x10112158 */
        l_0x1011_2156:
            ii(0x1011_2156, 2); jmp(0x1011_216a, 0x12); goto l_0x1011_216a; /* jmp 0x1011216a */
        l_0x1011_2158:
            ii(0x1011_2158, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1011_215c, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1011_215f, 6); mov(eax, memd[ds, eax + 0x101b_901c]);  /* mov eax, [eax+0x101b901c] */
            ii(0x1011_2165, 5); call(0x100c_fbbe, -0x4_25ac);           /* call 0x100cfbbe */
        l_0x1011_216a:
            ii(0x1011_216a, 4); mov(memb[ss, ebp - 0x18], 0x1);         /* mov byte [ebp-0x18], 0x1 */
        l_0x1011_216e:
            ii(0x1011_216e, 5); jmp(0x1011_21fc, 0x89); goto l_0x1011_21fc; /* jmp 0x101121fc */
        l_0x1011_2173:
            ii(0x1011_2173, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1011_2176, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x1011_2179, 5); cmp(memw[ss, ebp - 0x40], 0x4c);        /* cmp word [ebp-0x40], 0x4c */
            ii(0x1011_217e, 2); if(jb(0x1011_21ca, 0x4a)) goto l_0x1011_21ca; /* jb 0x101121ca */
            ii(0x1011_2180, 5); cmp(memw[ss, ebp - 0x40], 0x4c);        /* cmp word [ebp-0x40], 0x4c */
            ii(0x1011_2185, 6); if(jbe(0x1011_2024, -0x167)) goto l_0x1011_2024; /* jbe 0x10112024 */
            ii(0x1011_218b, 5); cmp(memw[ss, ebp - 0x40], 0x4e);        /* cmp word [ebp-0x40], 0x4e */
            ii(0x1011_2190, 2); if(jb(0x1011_21c5, 0x33)) goto l_0x1011_21c5; /* jb 0x101121c5 */
            ii(0x1011_2192, 5); cmp(memw[ss, ebp - 0x40], 0x4e);        /* cmp word [ebp-0x40], 0x4e */
            ii(0x1011_2197, 6); if(jbe(0x1011_1fff, -0x19e)) goto l_0x1011_1fff; /* jbe 0x10111fff */
            ii(0x1011_219d, 5); cmp(memw[ss, ebp - 0x40], 0x53);        /* cmp word [ebp-0x40], 0x53 */
            ii(0x1011_21a2, 2); if(jb(0x1011_21c0, 0x1c)) goto l_0x1011_21c0; /* jb 0x101121c0 */
            ii(0x1011_21a4, 5); cmp(memw[ss, ebp - 0x40], 0x53);        /* cmp word [ebp-0x40], 0x53 */
            ii(0x1011_21a9, 6); if(jbe(0x1011_20c0, -0xef)) goto l_0x1011_20c0; /* jbe 0x101120c0 */
            ii(0x1011_21af, 6); cmp(memw[ss, ebp - 0x40], 0x148);       /* cmp word [ebp-0x40], 0x148 */
            ii(0x1011_21b5, 6); if(jz(0x1011_211e, -0x9d)) goto l_0x1011_211e; /* jz 0x1011211e */
            ii(0x1011_21bb, 5); jmp(0x1011_2135, -0x8b); goto l_0x1011_2135; /* jmp 0x10112135 */
        l_0x1011_21c0:
            ii(0x1011_21c0, 5); jmp(0x1011_2135, -0x90); goto l_0x1011_2135; /* jmp 0x10112135 */
        l_0x1011_21c5:
            ii(0x1011_21c5, 5); jmp(0x1011_209b, -0x12f); goto l_0x1011_209b; /* jmp 0x1011209b */
        l_0x1011_21ca:
            ii(0x1011_21ca, 5); cmp(memw[ss, ebp - 0x40], 0x45);        /* cmp word [ebp-0x40], 0x45 */
            ii(0x1011_21cf, 2); if(jb(0x1011_21ec, 0x1b)) goto l_0x1011_21ec; /* jb 0x101121ec */
            ii(0x1011_21d1, 5); cmp(memw[ss, ebp - 0x40], 0x45);        /* cmp word [ebp-0x40], 0x45 */
            ii(0x1011_21d6, 6); if(jbe(0x1011_210f, -0xcd)) goto l_0x1011_210f; /* jbe 0x1011210f */
            ii(0x1011_21dc, 5); cmp(memw[ss, ebp - 0x40], 0x49);        /* cmp word [ebp-0x40], 0x49 */
            ii(0x1011_21e1, 6); if(jz(0x1011_20dc, -0x10b)) goto l_0x1011_20dc; /* jz 0x101120dc */
            ii(0x1011_21e7, 5); jmp(0x1011_2135, -0xb7); goto l_0x1011_2135; /* jmp 0x10112135 */
        l_0x1011_21ec:
            ii(0x1011_21ec, 5); cmp(memw[ss, ebp - 0x40], 0x43);        /* cmp word [ebp-0x40], 0x43 */
            ii(0x1011_21f1, 6); if(jz(0x1011_20f8, -0xff)) goto l_0x1011_20f8; /* jz 0x101120f8 */
            ii(0x1011_21f7, 5); jmp(0x1011_2135, -0xc7); goto l_0x1011_2135; /* jmp 0x10112135 */
        l_0x1011_21fc:
            ii(0x1011_21fc, 5); jmp(0x1011_1f2c, -0x2d5); goto l_0x1011_1f2c; /* jmp 0x10111f2c */
        l_0x1011_2201:
            ii(0x1011_2201, 5); jmp(0x1011_1e71, -0x395); goto l_0x1011_1e71; /* jmp 0x10111e71 */
        }
    }
}

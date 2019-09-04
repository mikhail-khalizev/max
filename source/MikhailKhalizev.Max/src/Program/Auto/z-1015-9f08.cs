using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_9f08-53fc50d9")]
        public void Method_1015_9f08()
        {
            ii(0x1015_9f08, 5);  push(0x1d4);                          /* push 0x1d4 */
            ii(0x1015_9f0d, 5);  call(Definitions.sys_check_available_stack_size, 0xbe40);/* call 0x10165d52 */
            ii(0x1015_9f12, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_9f13, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_9f14, 1);  push(esi);                            /* push esi */
            ii(0x1015_9f15, 1);  push(edi);                            /* push edi */
            ii(0x1015_9f16, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_9f17, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_9f19, 6);  sub(esp, 0x1b0);                      /* sub esp, 0x1b0 */
            ii(0x1015_9f1f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_9f22, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_9f25, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_9f28, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1015_9f2b, 4);  or(memb[ss, ebp - 12], 1);            /* or byte [ebp-0xc], 0x1 */
            ii(0x1015_9f2f, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1015_9f32, 5);  call(Definitions.my_ctor_0x101b_38f8, -0xe_3847);/* call 0x100766f0 */
            ii(0x1015_9f37, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1015_9f3a, 4);  and(memb[ss, ebp - 12], -2 /* 0xfe */);/* and byte [ebp-0xc], 0xfe */
            ii(0x1015_9f3e, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1015_9f43, 5);  call(0x100f_448c, -0x6_5abc);         /* call 0x100f448c */
            ii(0x1015_9f48, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1015_9f4b, 4);  cmp(memb[ds, eax + 61], 0xb);         /* cmp byte [eax+0x3d], 0xb */
            ii(0x1015_9f4f, 2);  if(jnz(0x1015_9f70, 0x1f)) goto l_0x1015_9f70;/* jnz 0x10159f70 */
            ii(0x1015_9f51, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1015_9f54, 5);  call(0x100f_3f62, -0x6_5ff7);         /* call 0x100f3f62 */
            ii(0x1015_9f59, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1015_9f5c, 5);  call(0x100f_fa70, -0x5_a4f1);         /* call 0x100ffa70 */
            ii(0x1015_9f61, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_9f63, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1015_9f66, 5);  call(0x1007_5f2c, -0xe_403f);         /* call 0x10075f2c */
            ii(0x1015_9f6b, 5);  jmp(0x1015_a082, 0x112); goto l_0x1015_a082;/* jmp 0x1015a082 */
        l_0x1015_9f70:
            ii(0x1015_9f70, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1015_9f73, 3);  mov(ebx, memd[ds, eax + 26]);         /* mov ebx, [eax+0x1a] */
            ii(0x1015_9f76, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1015_9f79, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1015_9f7c, 3);  mov(edx, memd[ds, eax + 24]);         /* mov edx, [eax+0x18] */
            ii(0x1015_9f7f, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1015_9f82, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1015_9f85, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1015_9f88, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1015_9f8a, 1);  cwde();                               /* cwde */
            ii(0x1015_9f8b, 5);  call(0x1007_41dc, -0xe_5db4);         /* call 0x100741dc */
            ii(0x1015_9f90, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_9f92, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1015_9f95, 5);  call(0x1007_6630, -0xe_396a);         /* call 0x10076630 */
            ii(0x1015_9f9a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_9f9c, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1015_9f9f, 5);  call(0x1013_ad11, -0x1_f293);         /* call 0x1013ad11 */
            ii(0x1015_9fa4, 2);  test(al, al);                         /* test al, al */
            ii(0x1015_9fa6, 2);  if(jz(0x1015_9fd0, 0x28)) goto l_0x1015_9fd0;/* jz 0x10159fd0 */
            ii(0x1015_9fa8, 5);  call(0x100c_aa00, -0x8_f5ad);         /* call 0x100caa00 */
            ii(0x1015_9fad, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1015_9fb2, 1);  push(eax);                            /* push eax */
            ii(0x1015_9fb3, 5);  call(0x100c_aa20, -0x8_f598);         /* call 0x100caa20 */
            ii(0x1015_9fb8, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1015_9fba, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1015_9fbc, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1015_9fc1, 5);  mov(eax, StringDefinitions.UnableToClearAtCurrentLocation);/* mov eax, 0x101b26ae */
            ii(0x1015_9fc6, 5);  call(0x1011_5d23, -0x4_42a8);         /* call 0x10115d23 */
            ii(0x1015_9fcb, 5);  jmp(0x1015_a078, 0xa8); goto l_0x1015_a078;/* jmp 0x1015a078 */
        l_0x1015_9fd0:
            ii(0x1015_9fd0, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1015_9fd3, 5);  call(0x1007_6600, -0xe_39d8);         /* call 0x10076600 */
            ii(0x1015_9fd8, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_9fda, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1015_9fdd, 5);  call(0x1008_a998, -0xc_f64a);         /* call 0x1008a998 */
            ii(0x1015_9fe2, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1015_9fe5, 5);  call(0x1007_6574, -0xe_3a76);         /* call 0x10076574 */
            ii(0x1015_9fea, 4);  test(memb[ds, eax + 18], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1015_9fee, 2);  if(jz(0x1015_9ff9, 9)) goto l_0x1015_9ff9;/* jz 0x10159ff9 */
            ii(0x1015_9ff0, 7);  mov(memd[ss, ebp - 28], 4);           /* mov dword [ebp-0x1c], 0x4 */
            ii(0x1015_9ff7, 2);  jmp(0x1015_a000, 7); goto l_0x1015_a000;/* jmp 0x1015a000 */
        l_0x1015_9ff9:
            ii(0x1015_9ff9, 7);  mov(memd[ss, ebp - 28], 1);           /* mov dword [ebp-0x1c], 0x1 */
        l_0x1015_a000:
            ii(0x1015_a000, 3);  mov(al, memb[ss, ebp - 28]);          /* mov al, [ebp-0x1c] */
            ii(0x1015_a003, 3);  mov(edx, memd[ss, ebp - 24]);         /* mov edx, [ebp-0x18] */
            ii(0x1015_a006, 3);  mov(memb[ds, edx + 69], al);          /* mov [edx+0x45], al */
            ii(0x1015_a009, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1015_a00b, 5);  mov(edx, 0xb);                        /* mov edx, 0xb */
            ii(0x1015_a010, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1015_a013, 5);  call(0x1016_3053, 0x903b);            /* call 0x10163053 */
            ii(0x1015_a018, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1015_a01b, 5);  call(0x1010_094d, -0x5_96d3);         /* call 0x1010094d */
            ii(0x1015_a020, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1015_a023, 5);  call(0x1010_19b8, -0x5_8670);         /* call 0x101019b8 */
            ii(0x1015_a028, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1015_a02b, 3);  mov(al, memb[ds, eax + 69]);          /* mov al, [eax+0x45] */
            ii(0x1015_a02e, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1015_a033, 1);  push(eax);                            /* push eax */
            ii(0x1015_a034, 5);  mov(eax, StringDefinitions.NumberOfTurnsToClearSiteI3);/* mov eax, 0x101b26d3 */
            ii(0x1015_a039, 1);  push(eax);                            /* push eax */
            ii(0x1015_a03a, 6);  lea(eax, memd[ss, ebp - 428]);        /* lea eax, [ebp-0x1ac] */
            ii(0x1015_a040, 1);  push(eax);                            /* push eax */
            ii(0x1015_a041, 5);  call(Definitions.sys_sprintf, 0xbebb);/* call 0x10165f01 */
            ii(0x1015_a046, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x1015_a049, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1015_a04c, 3);  mov(ebx, memd[ds, eax + 26]);         /* mov ebx, [eax+0x1a] */
            ii(0x1015_a04f, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1015_a052, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1015_a055, 3);  mov(edx, memd[ds, eax + 24]);         /* mov edx, [eax+0x18] */
            ii(0x1015_a058, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1015_a05b, 6);  lea(eax, memd[ss, ebp - 432]);        /* lea eax, [ebp-0x1b0] */
            ii(0x1015_a061, 5);  call(0x1007_6aac, -0xe_35ba);         /* call 0x10076aac */
            ii(0x1015_a066, 2);  mov(ecx, memd[ds, eax]);              /* mov ecx, [eax] */
            ii(0x1015_a068, 3);  mov(ebx, memd[ss, ebp - 24]);         /* mov ebx, [ebp-0x18] */
            ii(0x1015_a06b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_a06d, 6);  lea(eax, memd[ss, ebp - 428]);        /* lea eax, [ebp-0x1ac] */
            ii(0x1015_a073, 5);  call(0x1011_5b60, -0x4_4518);         /* call 0x10115b60 */
        l_0x1015_a078:
            ii(0x1015_a078, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_a07a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1015_a07d, 5);  call(0x1007_5f2c, -0xe_4156);         /* call 0x10075f2c */
        l_0x1015_a082:
            ii(0x1015_a082, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_a084, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_a085, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_a086, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_a087, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_a088, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_a089, 1);  ret();                                /* ret */
        }
    }
}

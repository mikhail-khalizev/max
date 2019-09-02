using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_3f3f-f28424aa")]
        public void Method_100a_3f3f()
        {
            ii(0x100a_3f3f, 5); push(0x3c);                             /* push 0x3c */
            ii(0x100a_3f44, 5); call(Definitions.sys_check_available_stack_size, 0xc_1e09); /* call 0x10165d52 */
            ii(0x100a_3f49, 1); push(ebx);                              /* push ebx */
            ii(0x100a_3f4a, 1); push(ecx);                              /* push ecx */
            ii(0x100a_3f4b, 1); push(edx);                              /* push edx */
            ii(0x100a_3f4c, 1); push(esi);                              /* push esi */
            ii(0x100a_3f4d, 1); push(edi);                              /* push edi */
            ii(0x100a_3f4e, 1); push(ebp);                              /* push ebp */
            ii(0x100a_3f4f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_3f51, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100a_3f57, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_3f5a, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_3f5f, 5); call(0x1008_a768, -0x1_97fc);           /* call 0x1008a768 */
            ii(0x100a_3f64, 3); lea(ebx, memd[ss, ebp - 0x10]);         /* lea ebx, [ebp-0x10] */
            ii(0x100a_3f67, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_3f69, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_3f6b, 5); call(0x1008_ae70, -0x1_9100);           /* call 0x1008ae70 */
            ii(0x100a_3f70, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_3f73, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x100a_3f76, 5); call(0x100a_ad20, 0x6da5);              /* call 0x100aad20 */
            ii(0x100a_3f7b, 3); lea(ebx, memd[ss, ebp - 0xc]);          /* lea ebx, [ebp-0xc] */
            ii(0x100a_3f7e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_3f80, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_3f82, 5); call(0x100a_abfc, 0x6c75);              /* call 0x100aabfc */
            ii(0x100a_3f87, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x100a_3f8e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_3f91, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x100a_3f94, 5); call(0x1013_a794, 0x9_67fb);            /* call 0x1013a794 */
            ii(0x100a_3f99, 3); lea(ebx, memd[ds, eax - 0x24]);         /* lea ebx, [eax-0x24] */
            ii(0x100a_3f9c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_3f9f, 5); call(0x1013_a794, 0x9_67f0);            /* call 0x1013a794 */
            ii(0x100a_3fa4, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x100a_3fa6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_3fa9, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x100a_3fac, 5); call(0x1013_a794, 0x9_67e3);            /* call 0x1013a794 */
            ii(0x100a_3fb1, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x100a_3fb3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_3fb6, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_3fb9, 5); call(0x1007_6b90, -0x2_d42e);           /* call 0x10076b90 */
            ii(0x100a_3fbe, 1); cwde();                                 /* cwde */
            ii(0x100a_3fbf, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x100a_3fc1, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x100a_3fc4, 2); jmp(0x100a_3fce, 8); goto l_0x100a_3fce; /* jmp 0x100a3fce */
        l_0x100a_3fc6:
            ii(0x100a_3fc6, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_3fc9, 5); call(0x1007_6bf8, -0x2_d3d6);           /* call 0x10076bf8 */
        l_0x100a_3fce:
            ii(0x100a_3fce, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_3fd0, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_3fd3, 5); call(0x1013_ad71, 0x9_6d99);            /* call 0x1013ad71 */
            ii(0x100a_3fd8, 2); test(al, al);                           /* test al, al */
            ii(0x100a_3fda, 2); if(jz(0x100a_3ff8, 0x1c)) goto l_0x100a_3ff8; /* jz 0x100a3ff8 */
            ii(0x100a_3fdc, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_3fdf, 5); call(0x1008_adc4, -0x1_9220);           /* call 0x1008adc4 */
            ii(0x100a_3fe4, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100a_3fe7, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100a_3fea, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100a_3fed, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100a_3ff0, 3); call_abs(memd[ds, edx + 0x10]);         /* call dword [edx+0x10] */
            ii(0x100a_3ff3, 3); add(memd[ss, ebp - 8], eax);            /* add [ebp-0x8], eax */
            ii(0x100a_3ff6, 2); jmp(0x100a_3fc6, -0x32); goto l_0x100a_3fc6; /* jmp 0x100a3fc6 */
        l_0x100a_3ff8:
            ii(0x100a_3ff8, 2); jmp(0x100a_4002, 8); goto l_0x100a_4002; /* jmp 0x100a4002 */
        l_0x100a_3ffa:
            ii(0x100a_3ffa, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_3ffd, 5); call(0x1007_6bf8, -0x2_d40a);           /* call 0x10076bf8 */
        l_0x100a_4002:
            ii(0x100a_4002, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4004, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_4007, 5); call(0x1013_ad71, 0x9_6d65);            /* call 0x1013ad71 */
            ii(0x100a_400c, 2); test(al, al);                           /* test al, al */
            ii(0x100a_400e, 2); if(jz(0x100a_402c, 0x1c)) goto l_0x100a_402c; /* jz 0x100a402c */
            ii(0x100a_4010, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_4013, 5); call(0x100a_ab4c, 0x6b34);              /* call 0x100aab4c */
            ii(0x100a_4018, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100a_401b, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_401e, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100a_4021, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_4024, 3); call_abs(memd[ds, edx + 0xc]);          /* call dword [edx+0xc] */
            ii(0x100a_4027, 3); add(memd[ss, ebp - 8], eax);            /* add [ebp-0x8], eax */
            ii(0x100a_402a, 2); jmp(0x100a_3ffa, -0x32); goto l_0x100a_3ffa; /* jmp 0x100a3ffa */
        l_0x100a_402c:
            ii(0x100a_402c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_402f, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_4032, 5); call(0x100a_ad20, 0x6ce9);              /* call 0x100aad20 */
            ii(0x100a_4037, 3); lea(ebx, memd[ss, ebp - 0xc]);          /* lea ebx, [ebp-0xc] */
            ii(0x100a_403a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_403c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_403e, 5); call(0x100a_ab80, 0x6b3d);              /* call 0x100aab80 */
            ii(0x100a_4043, 2); jmp(0x100a_404d, 8); goto l_0x100a_404d; /* jmp 0x100a404d */
        l_0x100a_4045:
            ii(0x100a_4045, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_4048, 5); call(0x1007_6bf8, -0x2_d455);           /* call 0x10076bf8 */
        l_0x100a_404d:
            ii(0x100a_404d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_404f, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_4052, 5); call(0x1013_ad71, 0x9_6d1a);            /* call 0x1013ad71 */
            ii(0x100a_4057, 2); test(al, al);                           /* test al, al */
            ii(0x100a_4059, 2); if(jz(0x100a_4077, 0x1c)) goto l_0x100a_4077; /* jz 0x100a4077 */
            ii(0x100a_405b, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_405e, 5); call(0x100a_ab4c, 0x6ae9);              /* call 0x100aab4c */
            ii(0x100a_4063, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100a_4066, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100a_4069, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100a_406c, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100a_406f, 3); call_abs(memd[ds, edx + 0xc]);          /* call dword [edx+0xc] */
            ii(0x100a_4072, 3); add(memd[ss, ebp - 8], eax);            /* add [ebp-0x8], eax */
            ii(0x100a_4075, 2); jmp(0x100a_4045, -0x32); goto l_0x100a_4045; /* jmp 0x100a4045 */
        l_0x100a_4077:
            ii(0x100a_4077, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_407a, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100a_407d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_407f, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_4082, 5); call(0x100a_a178, 0x60f1);              /* call 0x100aa178 */
            ii(0x100a_4087, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4089, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_408c, 5); call(0x1008_8bbc, -0x1_b4d5);           /* call 0x10088bbc */
            ii(0x100a_4091, 2); jmp(0x100a_40a7, 0x14); goto l_0x100a_40a7; /* jmp 0x100a40a7 */
        //  ii(0x100a_4093, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100a_4095, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
        //  ii(0x100a_4098, 5); call(0x100a_a178, 0x60db);              /* call 0x100aa178 */
        //  ii(0x100a_409d, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100a_409f, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
        //  ii(0x100a_40a2, 5); call(0x1008_8bbc, -0x1_b4eb);           /* call 0x10088bbc */
        l_0x100a_40a7:
            ii(0x100a_40a7, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100a_40aa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_40ac, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_40ad, 1); pop(edi);                               /* pop edi */
            ii(0x100a_40ae, 1); pop(esi);                               /* pop esi */
            ii(0x100a_40af, 1); pop(edx);                               /* pop edx */
            ii(0x100a_40b0, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_40b1, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_40b2, 1); ret();                                  /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_0f77-5e43c60f")]
        public void Method_100a_0f77()
        {
            ii(0x100a_0f77, 5); push(0x15c);                            /* push 0x15c */
            ii(0x100a_0f7c, 5); call(Definitions.sys_check_available_stack_size, 0xc_4dd1); /* call 0x10165d52 */
            ii(0x100a_0f81, 1); push(esi);                              /* push esi */
            ii(0x100a_0f82, 1); push(edi);                              /* push edi */
            ii(0x100a_0f83, 1); push(ebp);                              /* push ebp */
            ii(0x100a_0f84, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_0f86, 6); sub(esp, 0x13c);                        /* sub esp, 0x13c */
            ii(0x100a_0f8c, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100a_0f8f, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x100a_0f92, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x100a_0f95, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x100a_0f98, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_0f9b, 4); cmp(memb[ds, eax + 76], 0);             /* cmp byte [eax+0x4c], 0x0 */
            ii(0x100a_0f9f, 2); if(jz(0x100a_0fb8, 0x17)) goto l_0x100a_0fb8; /* jz 0x100a0fb8 */
            ii(0x100a_0fa1, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x100a_0fa4, 3); add(edx, 8);                            /* add edx, 0x8 */
            ii(0x100a_0fa7, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_0faa, 3); add(eax, 0x48);                         /* add eax, 0x48 */
            ii(0x100a_0fad, 5); call(0x1008_b268, -0x1_5d4a);           /* call 0x1008b268 */
            ii(0x100a_0fb2, 1); cwde();                                 /* cwde */
            ii(0x100a_0fb3, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x100a_0fb6, 2); if(jz(0x100a_0fbd, 5)) goto l_0x100a_0fbd; /* jz 0x100a0fbd */
        l_0x100a_0fb8:
            ii(0x100a_0fb8, 5); jmp(0x100a_1064, 0xa7); goto l_0x100a_1064; /* jmp 0x100a1064 */
        l_0x100a_0fbd:
            ii(0x100a_0fbd, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x100a_0fc0, 3); add(edx, 8);                            /* add edx, 0x8 */
            ii(0x100a_0fc3, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_0fc6, 3); add(eax, 0x48);                         /* add eax, 0x48 */
            ii(0x100a_0fc9, 5); call(0x1008_b2a8, -0x1_5d26);           /* call 0x1008b2a8 */
            ii(0x100a_0fce, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x100a_0fd1, 3); add(edx, 0x44);                         /* add edx, 0x44 */
            ii(0x100a_0fd4, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_0fd7, 5); call(0x1007_6d98, -0x2_a244);           /* call 0x10076d98 */
            ii(0x100a_0fdc, 2); test(al, al);                           /* test al, al */
            ii(0x100a_0fde, 2); if(jz(0x100a_100b, 0x2b)) goto l_0x100a_100b; /* jz 0x100a100b */
            ii(0x100a_0fe0, 3); mov(eax, memd[ss, ebp + 16]);           /* mov eax, [ebp+0x10] */
            ii(0x100a_0fe3, 1); push(eax);                              /* push eax */
            ii(0x100a_0fe4, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_0fe7, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100a_0fea, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_0fed, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100a_0ff0, 6); push(memd[ds, eax + 0x101c_81d7]);      /* push dword [eax+0x101c81d7] */
            ii(0x100a_0ff6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_0ff9, 1); push(eax);                              /* push eax */
            ii(0x100a_0ffa, 6); lea(eax, memd[ss, ebp - 316]);          /* lea eax, [ebp-0x13c] */
            ii(0x100a_1000, 1); push(eax);                              /* push eax */
            ii(0x100a_1001, 5); call(Definitions.sys_sprintf, 0xc_4efb); /* call 0x10165f01 */
            ii(0x100a_1006, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x100a_1009, 2); jmp(0x100a_1053, 0x48); goto l_0x100a_1053; /* jmp 0x100a1053 */
        l_0x100a_100b:
            ii(0x100a_100b, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_100e, 3); mov(al, memb[ds, eax + 77]);            /* mov al, [eax+0x4d] */
            ii(0x100a_1011, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_1016, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1018, 2); if(jnz(0x100a_102a, 0x10)) goto l_0x100a_102a; /* jnz 0x100a102a */
            ii(0x100a_101a, 5); mov(edx, StringDefinitions.AdjustmentsMade); /* mov edx, 0x101a090f */
            ii(0x100a_101f, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_1022, 3); add(eax, 0x4d);                         /* add eax, 0x4d */
            ii(0x100a_1025, 5); call(Definitions.sys_strcpy, 0xc_4ea5); /* call 0x10165ecf */
        l_0x100a_102a:
            ii(0x100a_102a, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_102d, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100a_1030, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_1033, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100a_1036, 6); push(memd[ds, eax + 0x101c_81d7]);      /* push dword [eax+0x101c81d7] */
            ii(0x100a_103c, 3); mov(eax, memd[ss, ebp + 16]);           /* mov eax, [ebp+0x10] */
            ii(0x100a_103f, 1); push(eax);                              /* push eax */
            ii(0x100a_1040, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_1043, 1); push(eax);                              /* push eax */
            ii(0x100a_1044, 6); lea(eax, memd[ss, ebp - 316]);          /* lea eax, [ebp-0x13c] */
            ii(0x100a_104a, 1); push(eax);                              /* push eax */
            ii(0x100a_104b, 5); call(Definitions.sys_sprintf, 0xc_4eb1); /* call 0x10165f01 */
            ii(0x100a_1050, 3); add(esp, 0x10);                         /* add esp, 0x10 */
        l_0x100a_1053:
            ii(0x100a_1053, 6); lea(edx, memd[ss, ebp - 316]);          /* lea edx, [ebp-0x13c] */
            ii(0x100a_1059, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_105c, 3); add(eax, 0x4d);                         /* add eax, 0x4d */
            ii(0x100a_105f, 5); call(Definitions.sys_strcat, 0xc_4ecd); /* call 0x10165f31 */
        l_0x100a_1064:
            ii(0x100a_1064, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_1066, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_1067, 1); pop(edi);                               /* pop edi */
            ii(0x100a_1068, 1); pop(esi);                               /* pop esi */
            ii(0x100a_1069, 3); ret(4);                                 /* ret 0x4 */
        }
    }
}

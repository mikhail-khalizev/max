using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_b713-3b36912b")]
        public void Method_1010_b713()
        {
            ii(0x1010_b713, 5); push(0x44);                             /* push 0x44 */
            ii(0x1010_b718, 5); call(Definitions.sys_check_available_stack_size, 0x5_a635); /* call 0x10165d52 */
            ii(0x1010_b71d, 1); push(ebx);                              /* push ebx */
            ii(0x1010_b71e, 1); push(ecx);                              /* push ecx */
            ii(0x1010_b71f, 1); push(edx);                              /* push edx */
            ii(0x1010_b720, 1); push(esi);                              /* push esi */
            ii(0x1010_b721, 1); push(edi);                              /* push edi */
            ii(0x1010_b722, 1); push(ebp);                              /* push ebp */
            ii(0x1010_b723, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_b725, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1010_b72b, 7); mov(memd[ss, ebp - 0x4], 0x1);          /* mov dword [ebp-0x4], 0x1 */
            ii(0x1010_b732, 7); mov(memd[ss, ebp - 0x8], 0xf);          /* mov dword [ebp-0x8], 0xf */
            ii(0x1010_b739, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1010_b73e, 5); call(0x1007_5fdc, -0x9_5767);           /* call 0x10075fdc */
            ii(0x1010_b743, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_b746, 5); jmp(0x1010_b861, 0x116); goto l_0x1010_b861; /* jmp 0x1010b861 */
        l_0x1010_b74b:
            ii(0x1010_b74b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_b74d, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1010_b752, 5); call(0x100c_aafc, -0x4_0c5b);           /* call 0x100caafc */
            ii(0x1010_b757, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1010_b75c, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1010_b761, 5); call(0x100c_aafc, -0x4_0c6a);           /* call 0x100caafc */
            ii(0x1010_b766, 5); mov(edx, 0x8);                          /* mov edx, 0x8 */
            ii(0x1010_b76b, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
            ii(0x1010_b770, 5); call(0x100c_aafc, -0x4_0c79);           /* call 0x100caafc */
            ii(0x1010_b775, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x1010_b77a, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1010_b77f, 5); call(0x100c_aafc, -0x4_0c88);           /* call 0x100caafc */
            ii(0x1010_b784, 5); mov(edx, 0x1c);                         /* mov edx, 0x1c */
            ii(0x1010_b789, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1010_b78e, 5); call(0x100c_aafc, -0x4_0c97);           /* call 0x100caafc */
            ii(0x1010_b793, 5); mov(edx, 0x6);                          /* mov edx, 0x6 */
            ii(0x1010_b798, 5); mov(eax, 0xe);                          /* mov eax, 0xe */
            ii(0x1010_b79d, 5); call(0x100c_aafc, -0x4_0ca6);           /* call 0x100caafc */
            ii(0x1010_b7a2, 5); jmp(0x1010_b885, 0xde); goto l_0x1010_b885; /* jmp 0x1010b885 */
        l_0x1010_b7a7:
            ii(0x1010_b7a7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_b7a9, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1010_b7ae, 5); call(0x100c_aafc, -0x4_0cb7);           /* call 0x100caafc */
            ii(0x1010_b7b3, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x1010_b7b8, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1010_b7bd, 5); call(0x100c_aafc, -0x4_0cc6);           /* call 0x100caafc */
            ii(0x1010_b7c2, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1010_b7c7, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
            ii(0x1010_b7cc, 5); call(0x100c_aafc, -0x4_0cd5);           /* call 0x100caafc */
            ii(0x1010_b7d1, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1010_b7d6, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1010_b7db, 5); call(0x100c_aafc, -0x4_0ce4);           /* call 0x100caafc */
            ii(0x1010_b7e0, 5); mov(edx, 0x17);                         /* mov edx, 0x17 */
            ii(0x1010_b7e5, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1010_b7ea, 5); call(0x100c_aafc, -0x4_0cf3);           /* call 0x100caafc */
            ii(0x1010_b7ef, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x1010_b7f4, 5); mov(eax, 0xe);                          /* mov eax, 0xe */
            ii(0x1010_b7f9, 5); call(0x100c_aafc, -0x4_0d02);           /* call 0x100caafc */
            ii(0x1010_b7fe, 5); jmp(0x1010_b885, 0x82); goto l_0x1010_b885; /* jmp 0x1010b885 */
        l_0x1010_b803:
            ii(0x1010_b803, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1010_b808, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1010_b80d, 5); call(0x100c_aafc, -0x4_0d16);           /* call 0x100caafc */
            ii(0x1010_b812, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x1010_b817, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1010_b81c, 5); call(0x100c_aafc, -0x4_0d25);           /* call 0x100caafc */
            ii(0x1010_b821, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1010_b826, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
            ii(0x1010_b82b, 5); call(0x100c_aafc, -0x4_0d34);           /* call 0x100caafc */
            ii(0x1010_b830, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1010_b835, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1010_b83a, 5); call(0x100c_aafc, -0x4_0d43);           /* call 0x100caafc */
            ii(0x1010_b83f, 5); mov(edx, 0x13);                         /* mov edx, 0x13 */
            ii(0x1010_b844, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1010_b849, 5); call(0x100c_aafc, -0x4_0d52);           /* call 0x100caafc */
            ii(0x1010_b84e, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1010_b853, 5); mov(eax, 0xe);                          /* mov eax, 0xe */
            ii(0x1010_b858, 5); call(0x100c_aafc, -0x4_0d61);           /* call 0x100caafc */
            ii(0x1010_b85d, 2); jmp(0x1010_b885, 0x26); goto l_0x1010_b885; /* jmp 0x1010b885 */
        l_0x1010_b85f:
            ii(0x1010_b85f, 2); jmp(0x1010_b885, 0x24); goto l_0x1010_b885; /* jmp 0x1010b885 */
        l_0x1010_b861:
            ii(0x1010_b861, 4); cmp(memd[ss, ebp - 0xc], 0x1);          /* cmp dword [ebp-0xc], 0x1 */
            ii(0x1010_b865, 2); if(jb(0x1010_b879, 0x12)) goto l_0x1010_b879; /* jb 0x1010b879 */
            ii(0x1010_b867, 4); cmp(memd[ss, ebp - 0xc], 0x1);          /* cmp dword [ebp-0xc], 0x1 */
            ii(0x1010_b86b, 6); if(jbe(0x1010_b7a7, -0xca)) goto l_0x1010_b7a7; /* jbe 0x1010b7a7 */
            ii(0x1010_b871, 4); cmp(memd[ss, ebp - 0xc], 0x2);          /* cmp dword [ebp-0xc], 0x2 */
            ii(0x1010_b875, 2); if(jz(0x1010_b803, -0x74)) goto l_0x1010_b803; /* jz 0x1010b803 */
            ii(0x1010_b877, 2); jmp(0x1010_b85f, -0x1a); goto l_0x1010_b85f; /* jmp 0x1010b85f */
        l_0x1010_b879:
            ii(0x1010_b879, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1010_b87d, 6); if(jz(0x1010_b74b, -0x138)) goto l_0x1010_b74b; /* jz 0x1010b74b */
            ii(0x1010_b883, 2); jmp(0x1010_b85f, -0x26); goto l_0x1010_b85f; /* jmp 0x1010b85f */
        l_0x1010_b885:
            ii(0x1010_b885, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1010_b88a, 5); call(0x1007_5fdc, -0x9_58b3);           /* call 0x10075fdc */
            ii(0x1010_b88f, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_b892, 2); jmp(0x1010_b8b3, 0x1f); goto l_0x1010_b8b3; /* jmp 0x1010b8b3 */
        l_0x1010_b894:
            ii(0x1010_b894, 4); add(memd[ss, ebp - 0x4], 0x3);          /* add dword [ebp-0x4], 0x3 */
            ii(0x1010_b898, 3); inc(memd[ss, ebp - 0x8]);               /* inc dword [ebp-0x8] */
            ii(0x1010_b89b, 2); jmp(0x1010_b8cf, 0x32); goto l_0x1010_b8cf; /* jmp 0x1010b8cf */
        l_0x1010_b89d:
            ii(0x1010_b89d, 4); add(memd[ss, ebp - 0x4], 0x5);          /* add dword [ebp-0x4], 0x5 */
            ii(0x1010_b8a1, 4); add(memd[ss, ebp - 0x8], 0x2);          /* add dword [ebp-0x8], 0x2 */
            ii(0x1010_b8a5, 2); jmp(0x1010_b8cf, 0x28); goto l_0x1010_b8cf; /* jmp 0x1010b8cf */
        l_0x1010_b8a7:
            ii(0x1010_b8a7, 4); add(memd[ss, ebp - 0x4], 0x6);          /* add dword [ebp-0x4], 0x6 */
            ii(0x1010_b8ab, 4); add(memd[ss, ebp - 0x8], 0x3);          /* add dword [ebp-0x8], 0x3 */
            ii(0x1010_b8af, 2); jmp(0x1010_b8cf, 0x1e); goto l_0x1010_b8cf; /* jmp 0x1010b8cf */
        l_0x1010_b8b1:
            ii(0x1010_b8b1, 2); jmp(0x1010_b8cf, 0x1c); goto l_0x1010_b8cf; /* jmp 0x1010b8cf */
        l_0x1010_b8b3:
            ii(0x1010_b8b3, 4); cmp(memd[ss, ebp - 0x10], 0x1);         /* cmp dword [ebp-0x10], 0x1 */
            ii(0x1010_b8b7, 2); if(jb(0x1010_b8c7, 0xe)) goto l_0x1010_b8c7; /* jb 0x1010b8c7 */
            ii(0x1010_b8b9, 4); cmp(memd[ss, ebp - 0x10], 0x1);         /* cmp dword [ebp-0x10], 0x1 */
            ii(0x1010_b8bd, 2); if(jbe(0x1010_b89d, -0x22)) goto l_0x1010_b89d; /* jbe 0x1010b89d */
            ii(0x1010_b8bf, 4); cmp(memd[ss, ebp - 0x10], 0x2);         /* cmp dword [ebp-0x10], 0x2 */
            ii(0x1010_b8c3, 2); if(jz(0x1010_b8a7, -0x1e)) goto l_0x1010_b8a7; /* jz 0x1010b8a7 */
            ii(0x1010_b8c5, 2); jmp(0x1010_b8b1, -0x16); goto l_0x1010_b8b1; /* jmp 0x1010b8b1 */
        l_0x1010_b8c7:
            ii(0x1010_b8c7, 4); cmp(memd[ss, ebp - 0x10], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1010_b8cb, 2); if(jz(0x1010_b894, -0x39)) goto l_0x1010_b894; /* jz 0x1010b894 */
            ii(0x1010_b8cd, 2); jmp(0x1010_b8b1, -0x1e); goto l_0x1010_b8b1; /* jmp 0x1010b8b1 */
        l_0x1010_b8cf:
            ii(0x1010_b8cf, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1010_b8d4, 5); call(0x1007_5fdc, -0x9_58fd);           /* call 0x10075fdc */
            ii(0x1010_b8d9, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_b8dc, 5); jmp(0x1010_b9fd, 0x11c); goto l_0x1010_b9fd; /* jmp 0x1010b9fd */
        l_0x1010_b8e1:
            ii(0x1010_b8e1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1010_b8e6, 5); mov(eax, 0xf);                          /* mov eax, 0xf */
            ii(0x1010_b8eb, 5); call(0x100c_aafc, -0x4_0df4);           /* call 0x100caafc */
            ii(0x1010_b8f0, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1010_b8f5, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1010_b8fa, 5); call(0x100c_aafc, -0x4_0e03);           /* call 0x100caafc */
            ii(0x1010_b8ff, 5); mov(edx, 0x8);                          /* mov edx, 0x8 */
            ii(0x1010_b904, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x1010_b909, 5); call(0x100c_aafc, -0x4_0e12);           /* call 0x100caafc */
            ii(0x1010_b90e, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x1010_b913, 5); mov(eax, 0x12);                         /* mov eax, 0x12 */
            ii(0x1010_b918, 5); call(0x100c_aafc, -0x4_0e21);           /* call 0x100caafc */
            ii(0x1010_b91d, 5); mov(edx, 0x1d);                         /* mov edx, 0x1d */
            ii(0x1010_b922, 5); mov(eax, 0x13);                         /* mov eax, 0x13 */
            ii(0x1010_b927, 5); call(0x100c_aafc, -0x4_0e30);           /* call 0x100caafc */
            ii(0x1010_b92c, 5); mov(edx, 0x6);                          /* mov edx, 0x6 */
            ii(0x1010_b931, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1010_b936, 5); call(0x100c_aafc, -0x4_0e3f);           /* call 0x100caafc */
            ii(0x1010_b93b, 5); jmp(0x1010_ba21, 0xe1); goto l_0x1010_ba21; /* jmp 0x1010ba21 */
        l_0x1010_b940:
            ii(0x1010_b940, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1010_b945, 5); mov(eax, 0xf);                          /* mov eax, 0xf */
            ii(0x1010_b94a, 5); call(0x100c_aafc, -0x4_0e53);           /* call 0x100caafc */
            ii(0x1010_b94f, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1010_b954, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1010_b959, 5); call(0x100c_aafc, -0x4_0e62);           /* call 0x100caafc */
            ii(0x1010_b95e, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x1010_b963, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x1010_b968, 5); call(0x100c_aafc, -0x4_0e71);           /* call 0x100caafc */
            ii(0x1010_b96d, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1010_b972, 5); mov(eax, 0x12);                         /* mov eax, 0x12 */
            ii(0x1010_b977, 5); call(0x100c_aafc, -0x4_0e80);           /* call 0x100caafc */
            ii(0x1010_b97c, 5); mov(edx, 0x18);                         /* mov edx, 0x18 */
            ii(0x1010_b981, 5); mov(eax, 0x13);                         /* mov eax, 0x13 */
            ii(0x1010_b986, 5); call(0x100c_aafc, -0x4_0e8f);           /* call 0x100caafc */
            ii(0x1010_b98b, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x1010_b990, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1010_b995, 5); call(0x100c_aafc, -0x4_0e9e);           /* call 0x100caafc */
            ii(0x1010_b99a, 5); jmp(0x1010_ba21, 0x82); goto l_0x1010_ba21; /* jmp 0x1010ba21 */
        l_0x1010_b99f:
            ii(0x1010_b99f, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1010_b9a4, 5); mov(eax, 0xf);                          /* mov eax, 0xf */
            ii(0x1010_b9a9, 5); call(0x100c_aafc, -0x4_0eb2);           /* call 0x100caafc */
            ii(0x1010_b9ae, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1010_b9b3, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1010_b9b8, 5); call(0x100c_aafc, -0x4_0ec1);           /* call 0x100caafc */
            ii(0x1010_b9bd, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1010_b9c2, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x1010_b9c7, 5); call(0x100c_aafc, -0x4_0ed0);           /* call 0x100caafc */
            ii(0x1010_b9cc, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1010_b9d1, 5); mov(eax, 0x12);                         /* mov eax, 0x12 */
            ii(0x1010_b9d6, 5); call(0x100c_aafc, -0x4_0edf);           /* call 0x100caafc */
            ii(0x1010_b9db, 5); mov(edx, 0x14);                         /* mov edx, 0x14 */
            ii(0x1010_b9e0, 5); mov(eax, 0x13);                         /* mov eax, 0x13 */
            ii(0x1010_b9e5, 5); call(0x100c_aafc, -0x4_0eee);           /* call 0x100caafc */
            ii(0x1010_b9ea, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1010_b9ef, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1010_b9f4, 5); call(0x100c_aafc, -0x4_0efd);           /* call 0x100caafc */
            ii(0x1010_b9f9, 2); jmp(0x1010_ba21, 0x26); goto l_0x1010_ba21; /* jmp 0x1010ba21 */
        l_0x1010_b9fb:
            ii(0x1010_b9fb, 2); jmp(0x1010_ba21, 0x24); goto l_0x1010_ba21; /* jmp 0x1010ba21 */
        l_0x1010_b9fd:
            ii(0x1010_b9fd, 4); cmp(memd[ss, ebp - 0x14], 0x1);         /* cmp dword [ebp-0x14], 0x1 */
            ii(0x1010_ba01, 2); if(jb(0x1010_ba15, 0x12)) goto l_0x1010_ba15; /* jb 0x1010ba15 */
            ii(0x1010_ba03, 4); cmp(memd[ss, ebp - 0x14], 0x1);         /* cmp dword [ebp-0x14], 0x1 */
            ii(0x1010_ba07, 6); if(jbe(0x1010_b940, -0xcd)) goto l_0x1010_b940; /* jbe 0x1010b940 */
            ii(0x1010_ba0d, 4); cmp(memd[ss, ebp - 0x14], 0x2);         /* cmp dword [ebp-0x14], 0x2 */
            ii(0x1010_ba11, 2); if(jz(0x1010_b99f, -0x74)) goto l_0x1010_b99f; /* jz 0x1010b99f */
            ii(0x1010_ba13, 2); jmp(0x1010_b9fb, -0x1a); goto l_0x1010_b9fb; /* jmp 0x1010b9fb */
        l_0x1010_ba15:
            ii(0x1010_ba15, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1010_ba19, 6); if(jz(0x1010_b8e1, -0x13e)) goto l_0x1010_b8e1; /* jz 0x1010b8e1 */
            ii(0x1010_ba1f, 2); jmp(0x1010_b9fb, -0x26); goto l_0x1010_b9fb; /* jmp 0x1010b9fb */
        l_0x1010_ba21:
            ii(0x1010_ba21, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1010_ba26, 5); call(0x1007_5fdc, -0x9_5a4f);           /* call 0x10075fdc */
            ii(0x1010_ba2b, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1010_ba2e, 2); jmp(0x1010_ba4f, 0x1f); goto l_0x1010_ba4f; /* jmp 0x1010ba4f */
        l_0x1010_ba30:
            ii(0x1010_ba30, 4); add(memd[ss, ebp - 0x4], 0x2);          /* add dword [ebp-0x4], 0x2 */
            ii(0x1010_ba34, 3); inc(memd[ss, ebp - 0x8]);               /* inc dword [ebp-0x8] */
            ii(0x1010_ba37, 2); jmp(0x1010_ba6b, 0x32); goto l_0x1010_ba6b; /* jmp 0x1010ba6b */
        l_0x1010_ba39:
            ii(0x1010_ba39, 4); add(memd[ss, ebp - 0x4], 0x3);          /* add dword [ebp-0x4], 0x3 */
            ii(0x1010_ba3d, 4); add(memd[ss, ebp - 0x8], 0x2);          /* add dword [ebp-0x8], 0x2 */
            ii(0x1010_ba41, 2); jmp(0x1010_ba6b, 0x28); goto l_0x1010_ba6b; /* jmp 0x1010ba6b */
        l_0x1010_ba43:
            ii(0x1010_ba43, 4); add(memd[ss, ebp - 0x4], 0x4);          /* add dword [ebp-0x4], 0x4 */
            ii(0x1010_ba47, 4); add(memd[ss, ebp - 0x8], 0x3);          /* add dword [ebp-0x8], 0x3 */
            ii(0x1010_ba4b, 2); jmp(0x1010_ba6b, 0x1e); goto l_0x1010_ba6b; /* jmp 0x1010ba6b */
        l_0x1010_ba4d:
            ii(0x1010_ba4d, 2); jmp(0x1010_ba6b, 0x1c); goto l_0x1010_ba6b; /* jmp 0x1010ba6b */
        l_0x1010_ba4f:
            ii(0x1010_ba4f, 4); cmp(memd[ss, ebp - 0x18], 0x1);         /* cmp dword [ebp-0x18], 0x1 */
            ii(0x1010_ba53, 2); if(jb(0x1010_ba63, 0xe)) goto l_0x1010_ba63; /* jb 0x1010ba63 */
            ii(0x1010_ba55, 4); cmp(memd[ss, ebp - 0x18], 0x1);         /* cmp dword [ebp-0x18], 0x1 */
            ii(0x1010_ba59, 2); if(jbe(0x1010_ba39, -0x22)) goto l_0x1010_ba39; /* jbe 0x1010ba39 */
            ii(0x1010_ba5b, 4); cmp(memd[ss, ebp - 0x18], 0x2);         /* cmp dword [ebp-0x18], 0x2 */
            ii(0x1010_ba5f, 2); if(jz(0x1010_ba43, -0x1e)) goto l_0x1010_ba43; /* jz 0x1010ba43 */
            ii(0x1010_ba61, 2); jmp(0x1010_ba4d, -0x16); goto l_0x1010_ba4d; /* jmp 0x1010ba4d */
        l_0x1010_ba63:
            ii(0x1010_ba63, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1010_ba67, 2); if(jz(0x1010_ba30, -0x39)) goto l_0x1010_ba30; /* jz 0x1010ba30 */
            ii(0x1010_ba69, 2); jmp(0x1010_ba4d, -0x1e); goto l_0x1010_ba4d; /* jmp 0x1010ba4d */
        l_0x1010_ba6b:
            ii(0x1010_ba6b, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1010_ba70, 5); call(0x1007_5fdc, -0x9_5a99);           /* call 0x10075fdc */
            ii(0x1010_ba75, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_ba77, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1010_ba7c, 5); call(0x1007_5fdc, -0x9_5aa5);           /* call 0x10075fdc */
            ii(0x1010_ba81, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_ba83, 3); mov(memd[ss, ebp - 0x1c], edx);         /* mov [ebp-0x1c], edx */
            ii(0x1010_ba86, 5); jmp(0x1010_bafc, 0x71); goto l_0x1010_bafc; /* jmp 0x1010bafc */
        l_0x1010_ba8b:
            ii(0x1010_ba8b, 5); mov(edx, 0x31);                         /* mov edx, 0x31 */
            ii(0x1010_ba90, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1010_ba95, 5); call(0x100c_aafc, -0x4_0f9e);           /* call 0x100caafc */
            ii(0x1010_ba9a, 5); jmp(0x1010_bb0f, 0x70); goto l_0x1010_bb0f; /* jmp 0x1010bb0f */
        l_0x1010_ba9f:
            ii(0x1010_ba9f, 5); mov(edx, 0x2c);                         /* mov edx, 0x2c */
            ii(0x1010_baa4, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1010_baa9, 5); call(0x100c_aafc, -0x4_0fb2);           /* call 0x100caafc */
            ii(0x1010_baae, 2); jmp(0x1010_bb0f, 0x5f); goto l_0x1010_bb0f; /* jmp 0x1010bb0f */
        l_0x1010_bab0:
            ii(0x1010_bab0, 5); mov(edx, 0x28);                         /* mov edx, 0x28 */
            ii(0x1010_bab5, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1010_baba, 5); call(0x100c_aafc, -0x4_0fc3);           /* call 0x100caafc */
            ii(0x1010_babf, 2); jmp(0x1010_bb0f, 0x4e); goto l_0x1010_bb0f; /* jmp 0x1010bb0f */
        l_0x1010_bac1:
            ii(0x1010_bac1, 5); mov(edx, 0x24);                         /* mov edx, 0x24 */
            ii(0x1010_bac6, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1010_bacb, 5); call(0x100c_aafc, -0x4_0fd4);           /* call 0x100caafc */
            ii(0x1010_bad0, 2); jmp(0x1010_bb0f, 0x3d); goto l_0x1010_bb0f; /* jmp 0x1010bb0f */
        l_0x1010_bad2:
            ii(0x1010_bad2, 5); mov(edx, 0x21);                         /* mov edx, 0x21 */
            ii(0x1010_bad7, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1010_badc, 5); call(0x100c_aafc, -0x4_0fe5);           /* call 0x100caafc */
            ii(0x1010_bae1, 2); jmp(0x1010_bb0f, 0x2c); goto l_0x1010_bb0f; /* jmp 0x1010bb0f */
        l_0x1010_bae3:
            ii(0x1010_bae3, 2); jmp(0x1010_bb0f, 0x2a); goto l_0x1010_bb0f; /* jmp 0x1010bb0f */
        //  ii(0x1010_bae5, 3); lea(eax, eax + 0);                      /* lea eax, [eax] */
        //  ii(0x1010_bae8, 20); /* Служебная область с абсолютными адресами переходов. (0x1010_ba8b, 0x1010_ba9f, 0x1010_bab0, 0x1010_bac1, 0x1010_bad2). */
        l_0x1010_bafc:
            ii(0x1010_bafc, 4); cmp(memd[ss, ebp - 0x1c], 0x4);         /* cmp dword [ebp-0x1c], 0x4 */
            ii(0x1010_bb00, 2); if(ja(0x1010_bae3, -0x1f)) goto l_0x1010_bae3; /* ja 0x1010bae3 */
            ii(0x1010_bb02, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1010_bb05, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_bb08, 7); 
            switch (jmp_abs_switch(memd[cs, eax + 0x1010_bae8]))
            {
                case 0x1010_ba8b:
                    goto l_0x1010_ba8b;
                case 0x1010_ba9f:
                    goto l_0x1010_ba9f;
                case 0x1010_bab0:
                    goto l_0x1010_bab0;
                case 0x1010_bac1:
                    goto l_0x1010_bac1;
                case 0x1010_bad2:
                    goto l_0x1010_bad2;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax+0x1010bae8] */
        l_0x1010_bb0f:
            ii(0x1010_bb0f, 5); mov(eax, 0x4f);                         /* mov eax, 0x4f */
            ii(0x1010_bb14, 5); call(0x1007_5fdc, -0x9_5b3d);           /* call 0x10075fdc */
            ii(0x1010_bb19, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1010_bb1c, 5); jmp(0x1010_bc2e, 0x10d); goto l_0x1010_bc2e; /* jmp 0x1010bc2e */
        l_0x1010_bb21:
            ii(0x1010_bb21, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_bb23, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x1010_bb28, 5); call(0x100c_aafc, -0x4_1031);           /* call 0x100caafc */
            ii(0x1010_bb2d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_bb2f, 5); mov(eax, 0x16);                         /* mov eax, 0x16 */
            ii(0x1010_bb34, 5); call(0x100c_aafc, -0x4_103d);           /* call 0x100caafc */
            ii(0x1010_bb39, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x1010_bb3e, 5); mov(eax, 0x17);                         /* mov eax, 0x17 */
            ii(0x1010_bb43, 5); call(0x100c_aafc, -0x4_104c);           /* call 0x100caafc */
            ii(0x1010_bb48, 5); mov(edx, 0x9);                          /* mov edx, 0x9 */
            ii(0x1010_bb4d, 5); mov(eax, 0x18);                         /* mov eax, 0x18 */
            ii(0x1010_bb52, 5); call(0x100c_aafc, -0x4_105b);           /* call 0x100caafc */
            ii(0x1010_bb57, 5); mov(edx, 0x27);                         /* mov edx, 0x27 */
            ii(0x1010_bb5c, 5); mov(eax, 0x19);                         /* mov eax, 0x19 */
            ii(0x1010_bb61, 5); call(0x100c_aafc, -0x4_106a);           /* call 0x100caafc */
            ii(0x1010_bb66, 5); mov(edx, 0x6);                          /* mov edx, 0x6 */
            ii(0x1010_bb6b, 5); mov(eax, 0x1a);                         /* mov eax, 0x1a */
            ii(0x1010_bb70, 5); call(0x100c_aafc, -0x4_1079);           /* call 0x100caafc */
            ii(0x1010_bb75, 5); jmp(0x1010_bc52, 0xd8); goto l_0x1010_bc52; /* jmp 0x1010bc52 */
        l_0x1010_bb7a:
            ii(0x1010_bb7a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_bb7c, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x1010_bb81, 5); call(0x100c_aafc, -0x4_108a);           /* call 0x100caafc */
            ii(0x1010_bb86, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_bb88, 5); mov(eax, 0x16);                         /* mov eax, 0x16 */
            ii(0x1010_bb8d, 5); call(0x100c_aafc, -0x4_1096);           /* call 0x100caafc */
            ii(0x1010_bb92, 5); mov(edx, 0x8);                          /* mov edx, 0x8 */
            ii(0x1010_bb97, 5); mov(eax, 0x17);                         /* mov eax, 0x17 */
            ii(0x1010_bb9c, 5); call(0x100c_aafc, -0x4_10a5);           /* call 0x100caafc */
            ii(0x1010_bba1, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x1010_bba6, 5); mov(eax, 0x18);                         /* mov eax, 0x18 */
            ii(0x1010_bbab, 5); call(0x100c_aafc, -0x4_10b4);           /* call 0x100caafc */
            ii(0x1010_bbb0, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1010_bbb5, 5); mov(eax, 0x19);                         /* mov eax, 0x19 */
            ii(0x1010_bbba, 5); call(0x100c_aafc, -0x4_10c3);           /* call 0x100caafc */
            ii(0x1010_bbbf, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x1010_bbc4, 5); mov(eax, 0x1a);                         /* mov eax, 0x1a */
            ii(0x1010_bbc9, 5); call(0x100c_aafc, -0x4_10d2);           /* call 0x100caafc */
            ii(0x1010_bbce, 5); jmp(0x1010_bc52, 0x7f); goto l_0x1010_bc52; /* jmp 0x1010bc52 */
        l_0x1010_bbd3:
            ii(0x1010_bbd3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_bbd5, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x1010_bbda, 5); call(0x100c_aafc, -0x4_10e3);           /* call 0x100caafc */
            ii(0x1010_bbdf, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1010_bbe4, 5); mov(eax, 0x16);                         /* mov eax, 0x16 */
            ii(0x1010_bbe9, 5); call(0x100c_aafc, -0x4_10f2);           /* call 0x100caafc */
            ii(0x1010_bbee, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x1010_bbf3, 5); mov(eax, 0x17);                         /* mov eax, 0x17 */
            ii(0x1010_bbf8, 5); call(0x100c_aafc, -0x4_1101);           /* call 0x100caafc */
            ii(0x1010_bbfd, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1010_bc02, 5); mov(eax, 0x18);                         /* mov eax, 0x18 */
            ii(0x1010_bc07, 5); call(0x100c_aafc, -0x4_1110);           /* call 0x100caafc */
            ii(0x1010_bc0c, 5); mov(edx, 0x1a);                         /* mov edx, 0x1a */
            ii(0x1010_bc11, 5); mov(eax, 0x19);                         /* mov eax, 0x19 */
            ii(0x1010_bc16, 5); call(0x100c_aafc, -0x4_111f);           /* call 0x100caafc */
            ii(0x1010_bc1b, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1010_bc20, 5); mov(eax, 0x1a);                         /* mov eax, 0x1a */
            ii(0x1010_bc25, 5); call(0x100c_aafc, -0x4_112e);           /* call 0x100caafc */
            ii(0x1010_bc2a, 2); jmp(0x1010_bc52, 0x26); goto l_0x1010_bc52; /* jmp 0x1010bc52 */
        l_0x1010_bc2c:
            ii(0x1010_bc2c, 2); jmp(0x1010_bc52, 0x24); goto l_0x1010_bc52; /* jmp 0x1010bc52 */
        l_0x1010_bc2e:
            ii(0x1010_bc2e, 4); cmp(memd[ss, ebp - 0x20], 0x1);         /* cmp dword [ebp-0x20], 0x1 */
            ii(0x1010_bc32, 2); if(jb(0x1010_bc46, 0x12)) goto l_0x1010_bc46; /* jb 0x1010bc46 */
            ii(0x1010_bc34, 4); cmp(memd[ss, ebp - 0x20], 0x1);         /* cmp dword [ebp-0x20], 0x1 */
            ii(0x1010_bc38, 6); if(jbe(0x1010_bb7a, -0xc4)) goto l_0x1010_bb7a; /* jbe 0x1010bb7a */
            ii(0x1010_bc3e, 4); cmp(memd[ss, ebp - 0x20], 0x2);         /* cmp dword [ebp-0x20], 0x2 */
            ii(0x1010_bc42, 2); if(jz(0x1010_bbd3, -0x71)) goto l_0x1010_bbd3; /* jz 0x1010bbd3 */
            ii(0x1010_bc44, 2); jmp(0x1010_bc2c, -0x1a); goto l_0x1010_bc2c; /* jmp 0x1010bc2c */
        l_0x1010_bc46:
            ii(0x1010_bc46, 4); cmp(memd[ss, ebp - 0x20], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1010_bc4a, 6); if(jz(0x1010_bb21, -0x12f)) goto l_0x1010_bb21; /* jz 0x1010bb21 */
            ii(0x1010_bc50, 2); jmp(0x1010_bc2c, -0x26); goto l_0x1010_bc2c; /* jmp 0x1010bc2c */
        l_0x1010_bc52:
            ii(0x1010_bc52, 5); mov(eax, 0x4f);                         /* mov eax, 0x4f */
            ii(0x1010_bc57, 5); call(0x1007_5fdc, -0x9_5c80);           /* call 0x10075fdc */
            ii(0x1010_bc5c, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1010_bc5f, 2); jmp(0x1010_bc73, 0x12); goto l_0x1010_bc73; /* jmp 0x1010bc73 */
        l_0x1010_bc61:
            ii(0x1010_bc61, 2); jmp(0x1010_bc8f, 0x2c); goto l_0x1010_bc8f; /* jmp 0x1010bc8f */
        l_0x1010_bc63:
            ii(0x1010_bc63, 3); inc(memd[ss, ebp - 0x8]);               /* inc dword [ebp-0x8] */
            ii(0x1010_bc66, 2); jmp(0x1010_bc8f, 0x27); goto l_0x1010_bc8f; /* jmp 0x1010bc8f */
        l_0x1010_bc68:
            ii(0x1010_bc68, 3); inc(memd[ss, ebp - 0x4]);               /* inc dword [ebp-0x4] */
            ii(0x1010_bc6b, 4); add(memd[ss, ebp - 0x8], 0x2);          /* add dword [ebp-0x8], 0x2 */
            ii(0x1010_bc6f, 2); jmp(0x1010_bc8f, 0x1e); goto l_0x1010_bc8f; /* jmp 0x1010bc8f */
        l_0x1010_bc71:
            ii(0x1010_bc71, 2); jmp(0x1010_bc8f, 0x1c); goto l_0x1010_bc8f; /* jmp 0x1010bc8f */
        l_0x1010_bc73:
            ii(0x1010_bc73, 4); cmp(memd[ss, ebp - 0x24], 0x1);         /* cmp dword [ebp-0x24], 0x1 */
            ii(0x1010_bc77, 2); if(jb(0x1010_bc87, 0xe)) goto l_0x1010_bc87; /* jb 0x1010bc87 */
            ii(0x1010_bc79, 4); cmp(memd[ss, ebp - 0x24], 0x1);         /* cmp dword [ebp-0x24], 0x1 */
            ii(0x1010_bc7d, 2); if(jbe(0x1010_bc63, -0x1c)) goto l_0x1010_bc63; /* jbe 0x1010bc63 */
            ii(0x1010_bc7f, 4); cmp(memd[ss, ebp - 0x24], 0x2);         /* cmp dword [ebp-0x24], 0x2 */
            ii(0x1010_bc83, 2); if(jz(0x1010_bc68, -0x1d)) goto l_0x1010_bc68; /* jz 0x1010bc68 */
            ii(0x1010_bc85, 2); jmp(0x1010_bc71, -0x16); goto l_0x1010_bc71; /* jmp 0x1010bc71 */
        l_0x1010_bc87:
            ii(0x1010_bc87, 4); cmp(memd[ss, ebp - 0x24], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1010_bc8b, 2); if(jz(0x1010_bc61, -0x2c)) goto l_0x1010_bc61; /* jz 0x1010bc61 */
            ii(0x1010_bc8d, 2); jmp(0x1010_bc71, -0x1e); goto l_0x1010_bc71; /* jmp 0x1010bc71 */
        l_0x1010_bc8f:
            ii(0x1010_bc8f, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1010_bc93, 5); mov(eax, 0x1c);                         /* mov eax, 0x1c */
            ii(0x1010_bc98, 5); call(0x100c_aafc, -0x4_11a1);           /* call 0x100caafc */
            ii(0x1010_bc9d, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1010_bca1, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x1010_bca6, 5); call(0x100c_aafc, -0x4_11af);           /* call 0x100caafc */
            ii(0x1010_bcab, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x1010_bcb0, 5); call(0x1007_5fdc, -0x9_5cd9);           /* call 0x10075fdc */
            ii(0x1010_bcb5, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1010_bcb8, 2); jmp(0x1010_bd0a, 0x50); goto l_0x1010_bd0a; /* jmp 0x1010bd0a */
        l_0x1010_bcba:
            ii(0x1010_bcba, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_bcbc, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1010_bcc1, 5); call(0x100c_aafc, -0x4_11ca);           /* call 0x100caafc */
            ii(0x1010_bcc6, 2); jmp(0x1010_bd26, 0x5e); goto l_0x1010_bd26; /* jmp 0x1010bd26 */
        l_0x1010_bcc8:
            ii(0x1010_bcc8, 5); mov(edx, 0x41);                         /* mov edx, 0x41 */
            ii(0x1010_bccd, 5); mov(eax, 0x2b);                         /* mov eax, 0x2b */
            ii(0x1010_bcd2, 5); call(0x100c_aafc, -0x4_11db);           /* call 0x100caafc */
            ii(0x1010_bcd7, 5); mov(edx, 0x14);                         /* mov edx, 0x14 */
            ii(0x1010_bcdc, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1010_bce1, 5); call(0x100c_aafc, -0x4_11ea);           /* call 0x100caafc */
            ii(0x1010_bce6, 2); jmp(0x1010_bd26, 0x3e); goto l_0x1010_bd26; /* jmp 0x1010bd26 */
        l_0x1010_bce8:
            ii(0x1010_bce8, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x1010_bced, 5); mov(eax, 0x2b);                         /* mov eax, 0x2b */
            ii(0x1010_bcf2, 5); call(0x100c_aafc, -0x4_11fb);           /* call 0x100caafc */
            ii(0x1010_bcf7, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x1010_bcfc, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1010_bd01, 5); call(0x100c_aafc, -0x4_120a);           /* call 0x100caafc */
            ii(0x1010_bd06, 2); jmp(0x1010_bd26, 0x1e); goto l_0x1010_bd26; /* jmp 0x1010bd26 */
        l_0x1010_bd08:
            ii(0x1010_bd08, 2); jmp(0x1010_bd26, 0x1c); goto l_0x1010_bd26; /* jmp 0x1010bd26 */
        l_0x1010_bd0a:
            ii(0x1010_bd0a, 4); cmp(memd[ss, ebp - 0x28], 0x1);         /* cmp dword [ebp-0x28], 0x1 */
            ii(0x1010_bd0e, 2); if(jb(0x1010_bd1e, 0xe)) goto l_0x1010_bd1e; /* jb 0x1010bd1e */
            ii(0x1010_bd10, 4); cmp(memd[ss, ebp - 0x28], 0x1);         /* cmp dword [ebp-0x28], 0x1 */
            ii(0x1010_bd14, 2); if(jbe(0x1010_bcc8, -0x4e)) goto l_0x1010_bcc8; /* jbe 0x1010bcc8 */
            ii(0x1010_bd16, 4); cmp(memd[ss, ebp - 0x28], 0x2);         /* cmp dword [ebp-0x28], 0x2 */
            ii(0x1010_bd1a, 2); if(jz(0x1010_bce8, -0x34)) goto l_0x1010_bce8; /* jz 0x1010bce8 */
            ii(0x1010_bd1c, 2); jmp(0x1010_bd08, -0x16); goto l_0x1010_bd08; /* jmp 0x1010bd08 */
        l_0x1010_bd1e:
            ii(0x1010_bd1e, 4); cmp(memd[ss, ebp - 0x28], 0);           /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1010_bd22, 2); if(jz(0x1010_bcba, -0x6a)) goto l_0x1010_bcba; /* jz 0x1010bcba */
            ii(0x1010_bd24, 2); jmp(0x1010_bd08, -0x1e); goto l_0x1010_bd08; /* jmp 0x1010bd08 */
        l_0x1010_bd26:
            ii(0x1010_bd26, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_bd28, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_bd29, 1); pop(edi);                               /* pop edi */
            ii(0x1010_bd2a, 1); pop(esi);                               /* pop esi */
            ii(0x1010_bd2b, 1); pop(edx);                               /* pop edx */
            ii(0x1010_bd2c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_bd2d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_bd2e, 1); ret();                                  /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_3b41-2d44653b")]
        public void Method_1016_3b41()
        {
            ii(0x1016_3b41, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1016_3b46, 5); call(Definitions.sys_check_available_stack_size, 0x2207); /* call 0x10165d52 */
            ii(0x1016_3b4b, 1); push(ebx);                              /* push ebx */
            ii(0x1016_3b4c, 1); push(ecx);                              /* push ecx */
            ii(0x1016_3b4d, 1); push(esi);                              /* push esi */
            ii(0x1016_3b4e, 1); push(edi);                              /* push edi */
            ii(0x1016_3b4f, 1); push(ebp);                              /* push ebp */
            ii(0x1016_3b50, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_3b52, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1016_3b58, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1016_3b5b, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x1016_3b5e, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1016_3b61, 3); mov(memb[ss, ebp - 12], al);            /* mov [ebp-0xc], al */
            ii(0x1016_3b64, 5); jmp(0x1016_3c08, 0x9f); goto l_0x1016_3c08; /* jmp 0x10163c08 */
        l_0x1016_3b69:
            ii(0x1016_3b69, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_3b6c, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1016_3b6f, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1016_3b72, 5); jmp(0x1016_3c47, 0xd0); goto l_0x1016_3c47; /* jmp 0x10163c47 */
        l_0x1016_3b77:
            ii(0x1016_3b77, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_3b7a, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1016_3b7d, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1016_3b80, 5); jmp(0x1016_3c47, 0xc2); goto l_0x1016_3c47; /* jmp 0x10163c47 */
        l_0x1016_3b85:
            ii(0x1016_3b85, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_3b88, 3); add(eax, 0x12);                         /* add eax, 0x12 */
            ii(0x1016_3b8b, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1016_3b8e, 5); jmp(0x1016_3c47, 0xb4); goto l_0x1016_3c47; /* jmp 0x10163c47 */
        l_0x1016_3b93:
            ii(0x1016_3b93, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_3b96, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1016_3b99, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1016_3b9c, 5); jmp(0x1016_3c47, 0xa6); goto l_0x1016_3c47; /* jmp 0x10163c47 */
        l_0x1016_3ba1:
            ii(0x1016_3ba1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_3ba4, 3); add(eax, 0xc);                          /* add eax, 0xc */
            ii(0x1016_3ba7, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1016_3baa, 5); jmp(0x1016_3c47, 0x98); goto l_0x1016_3c47; /* jmp 0x10163c47 */
        l_0x1016_3baf:
            ii(0x1016_3baf, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_3bb2, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1016_3bb5, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1016_3bb8, 5); jmp(0x1016_3c47, 0x8a); goto l_0x1016_3c47; /* jmp 0x10163c47 */
        l_0x1016_3bbd:
            ii(0x1016_3bbd, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_3bc0, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1016_3bc3, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1016_3bc6, 5); jmp(0x1016_3c47, 0x7c); goto l_0x1016_3c47; /* jmp 0x10163c47 */
        l_0x1016_3bcb:
            ii(0x1016_3bcb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_3bce, 3); add(eax, 0x10);                         /* add eax, 0x10 */
            ii(0x1016_3bd1, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1016_3bd4, 2); jmp(0x1016_3c47, 0x71); goto l_0x1016_3c47; /* jmp 0x10163c47 */
        l_0x1016_3bd6:
            ii(0x1016_3bd6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_3bd9, 3); add(eax, 8);                            /* add eax, 0x8 */
            ii(0x1016_3bdc, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1016_3bdf, 2); jmp(0x1016_3c47, 0x66); goto l_0x1016_3c47; /* jmp 0x10163c47 */
        l_0x1016_3be1:
            ii(0x1016_3be1, 2); jmp(0x1016_3c25, 0x42); goto l_0x1016_3c25; /* jmp 0x10163c25 */
        //  ii(0x1016_3be3, 1); nop();                                  /* nop */
        //  ii(0x1016_3be4, 36); /* Служебная область с абсолютными адресами переходов. (0x1016_3b69, 0x1016_3b77, 0x1016_3b85, 0x1016_3b93, 0x1016_3ba1, 0x1016_3baf, 0x1016_3bbd, 0x1016_3bcb, 0x1016_3bd6). */
        l_0x1016_3c08:
            ii(0x1016_3c08, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x1016_3c0b, 2); dec(al);                                /* dec al */
            ii(0x1016_3c0d, 3); mov(memb[ss, ebp - 20], al);            /* mov [ebp-0x14], al */
            ii(0x1016_3c10, 4); cmp(memb[ss, ebp - 20], 8);             /* cmp byte [ebp-0x14], 0x8 */
            ii(0x1016_3c14, 2); if(ja(0x1016_3be1, -0x35)) goto l_0x1016_3be1; /* ja 0x10163be1 */
            ii(0x1016_3c16, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_3c18, 3); mov(al, memb[ss, ebp - 20]);            /* mov al, [ebp-0x14] */
            ii(0x1016_3c1b, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1016_3c1e, 7); 
            switch (jmp_abs_switch(memd[cs, eax + 0x1016_3be4]))
            {
                case 0x1016_3b69:
                    goto l_0x1016_3b69;
                case 0x1016_3b77:
                    goto l_0x1016_3b77;
                case 0x1016_3b85:
                    goto l_0x1016_3b85;
                case 0x1016_3b93:
                    goto l_0x1016_3b93;
                case 0x1016_3ba1:
                    goto l_0x1016_3ba1;
                case 0x1016_3baf:
                    goto l_0x1016_3baf;
                case 0x1016_3bbd:
                    goto l_0x1016_3bbd;
                case 0x1016_3bcb:
                    goto l_0x1016_3bcb;
                case 0x1016_3bd6:
                    goto l_0x1016_3bd6;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax+0x10163be4] */
        l_0x1016_3c25:
            ii(0x1016_3c25, 5); mov(ecx, 0x1fd8);                       /* mov ecx, 0x1fd8 */
            ii(0x1016_3c2a, 5); mov(ebx, StringDefinitions.UnitsmgrCpp); /* mov ebx, 0x101b2b0d */
            ii(0x1016_3c2f, 5); mov(edx, StringDefinitions.UnitvaluesGetattributeCalledWithInvalidIndex); /* mov edx, 0x101b2b1a */
            ii(0x1016_3c34, 5); mov(eax, StringDefinitions.False2);     /* mov eax, 0x101b2b4e */
            ii(0x1016_3c39, 5); call(0x100f_07d4, -0x7_346a);           /* call 0x100f07d4 */
            ii(0x1016_3c3e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_3c41, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1016_3c44, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
        l_0x1016_3c47:
            ii(0x1016_3c47, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1016_3c4a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_3c4c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_3c4d, 1); pop(edi);                               /* pop edi */
            ii(0x1016_3c4e, 1); pop(esi);                               /* pop esi */
            ii(0x1016_3c4f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_3c50, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_3c51, 1); ret();                                  /* ret */
        }
    }
}

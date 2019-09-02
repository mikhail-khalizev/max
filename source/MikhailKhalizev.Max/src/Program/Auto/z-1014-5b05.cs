using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_5b05-b81ffc09")]
        public void Method_1014_5b05()
        {
            ii(0x1014_5b05, 5); push(0x24);                             /* push 0x24 */
            ii(0x1014_5b0a, 5); call(Definitions.sys_check_available_stack_size, 0x2_0243); /* call 0x10165d52 */
            ii(0x1014_5b0f, 1); push(ebx);                              /* push ebx */
            ii(0x1014_5b10, 1); push(ecx);                              /* push ecx */
            ii(0x1014_5b11, 1); push(esi);                              /* push esi */
            ii(0x1014_5b12, 1); push(edi);                              /* push edi */
            ii(0x1014_5b13, 1); push(ebp);                              /* push ebp */
            ii(0x1014_5b14, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5b16, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_5b1c, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_5b1f, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1014_5b22, 7); test(memd[ss, ebp - 4], 4);             /* test dword [ebp-0x4], 0x4 */
            ii(0x1014_5b29, 2); if(jz(0x1014_5b3f, 0x14)) goto l_0x1014_5b3f; /* jz 0x10145b3f */
            ii(0x1014_5b2b, 5); mov(edx, 0x101b_71bc);                  /* mov edx, 0x101b71bc */
            ii(0x1014_5b30, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_5b33, 5); call(Definitions.sys_call_dtor_arr, 0x2_0480); /* call 0x10165fb8 */
            ii(0x1014_5b38, 5); call(Definitions.sys_delete_arr, 0x2_049b); /* call 0x10165fd8 */
            ii(0x1014_5b3d, 2); jmp(0x1014_5b9c, 0x5d); goto l_0x1014_5b9c; /* jmp 0x10145b9c */
        l_0x1014_5b3f:
            ii(0x1014_5b3f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_5b42, 7); mov(memd[ds, eax + 2], 0x101b_71e4);    /* mov dword [eax+0x2], 0x101b71e4 */
        l_0x1014_5b49:
            ii(0x1014_5b49, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_5b4c, 5); call(0x1014_6462, 0x911);               /* call 0x10146462 */
            ii(0x1014_5b51, 2); test(al, al);                           /* test al, al */
            ii(0x1014_5b53, 2); if(jnz(0x1014_5b49, -0xc)) goto l_0x1014_5b49; /* jnz 0x10145b49 */
            ii(0x1014_5b55, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_5b57, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_5b5a, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x1014_5b5d, 5); call(0x1014_788c, 0x1d2a);              /* call 0x1014788c */
            ii(0x1014_5b62, 3); sub(eax, 0x1c);                         /* sub eax, 0x1c */
            ii(0x1014_5b65, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_5b68, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_5b6a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_5b6d, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1014_5b70, 5); call(0x100e_03bc, -0x6_57b9);           /* call 0x100e03bc */
            ii(0x1014_5b75, 3); sub(eax, 0x18);                         /* sub eax, 0x18 */
            ii(0x1014_5b78, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_5b7b, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1014_5b80, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_5b83, 5); call(0x1014_4fba, -0xbce);              /* call 0x10144fba */
            ii(0x1014_5b88, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_5b8b, 7); test(memd[ss, ebp - 4], 2);             /* test dword [ebp-0x4], 0x2 */
            ii(0x1014_5b92, 2); if(jz(0x1014_5b9c, 8)) goto l_0x1014_5b9c; /* jz 0x10145b9c */
            ii(0x1014_5b94, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_5b97, 5); call(Definitions.sys_delete, 0x2_03c8); /* call 0x10165f64 */
        l_0x1014_5b9c:
            ii(0x1014_5b9c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_5b9f, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_5ba2, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_5ba5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_5ba7, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_5ba8, 1); pop(edi);                               /* pop edi */
            ii(0x1014_5ba9, 1); pop(esi);                               /* pop esi */
            ii(0x1014_5baa, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_5bab, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_5bac, 1); ret();                                  /* ret */
        }
    }
}

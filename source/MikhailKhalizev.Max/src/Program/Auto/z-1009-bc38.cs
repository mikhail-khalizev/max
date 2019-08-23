using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_bc38-51922a00")]
        public void Method_1009_bc38()
        {
            ii(0x1009_bc38, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_bc3d, 5); call(Definitions.sys_check_available_stack_size, 0xc_a110); /* call 0x10165d52 */
            ii(0x1009_bc42, 1); push(ebx);                              /* push ebx */
            ii(0x1009_bc43, 1); push(ecx);                              /* push ecx */
            ii(0x1009_bc44, 1); push(esi);                              /* push esi */
            ii(0x1009_bc45, 1); push(edi);                              /* push edi */
            ii(0x1009_bc46, 1); push(ebp);                              /* push ebp */
            ii(0x1009_bc47, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_bc49, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_bc4f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_bc52, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_bc55, 7); test(memd[ss, ebp - 0x4], 0x4);         /* test dword [ebp-0x4], 0x4 */
            ii(0x1009_bc5c, 2); if(jz(0x1009_bc72, 0x14)) goto l_0x1009_bc72; /* jz 0x1009bc72 */
            ii(0x1009_bc5e, 5); mov(edx, 0x101b_40bc);                  /* mov edx, 0x101b40bc */
            ii(0x1009_bc63, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_bc66, 5); call(Definitions.sys_call_dtor_arr, 0xc_a34d); /* call 0x10165fb8 */
            ii(0x1009_bc6b, 5); call(Definitions.sys_delete_arr, 0xc_a368); /* call 0x10165fd8 */
            ii(0x1009_bc70, 2); jmp(0x1009_bc93, 0x21); goto l_0x1009_bc93; /* jmp 0x1009bc93 */
        l_0x1009_bc72:
            ii(0x1009_bc72, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1009_bc77, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_bc7a, 5); call(0x1009_b998, -0x2e7);              /* call 0x1009b998 */
            ii(0x1009_bc7f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_bc82, 7); test(memd[ss, ebp - 0x4], 0x2);         /* test dword [ebp-0x4], 0x2 */
            ii(0x1009_bc89, 2); if(jz(0x1009_bc93, 0x8)) goto l_0x1009_bc93; /* jz 0x1009bc93 */
            ii(0x1009_bc8b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_bc8e, 5); call(Definitions.sys_delete, 0xc_a2d1); /* call 0x10165f64 */
        l_0x1009_bc93:
            ii(0x1009_bc93, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_bc96, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_bc99, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_bc9c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_bc9e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_bc9f, 1); pop(edi);                               /* pop edi */
            ii(0x1009_bca0, 1); pop(esi);                               /* pop esi */
            ii(0x1009_bca1, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_bca2, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_bca3, 1); ret();                                  /* ret */
        }
    }
}

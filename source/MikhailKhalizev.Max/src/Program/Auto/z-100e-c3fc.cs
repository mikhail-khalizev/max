using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_c3fc-bc18665a")]
        public void Method_100e_c3fc()
        {
            ii(0x100e_c3fc, 5); push(0x28);                             /* push 0x28 */
            ii(0x100e_c401, 5); call(Definitions.sys_check_available_stack_size, 0x7_994c); /* call 0x10165d52 */
            ii(0x100e_c406, 1); push(ebx);                              /* push ebx */
            ii(0x100e_c407, 1); push(ecx);                              /* push ecx */
            ii(0x100e_c408, 1); push(edx);                              /* push edx */
            ii(0x100e_c409, 1); push(esi);                              /* push esi */
            ii(0x100e_c40a, 1); push(edi);                              /* push edi */
            ii(0x100e_c40b, 1); push(ebp);                              /* push ebp */
            ii(0x100e_c40c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_c40e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_c414, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_c417, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100e_c41b, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100e_c41e, 7); mov(ax, memw[ds, eax + 0x101c_81c0]);   /* mov ax, [eax+0x101c81c0] */
            ii(0x100e_c425, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_c428, 6); test(memw[ss, ebp - 8], 0x200);         /* test word [ebp-0x8], 0x200 */
            ii(0x100e_c42e, 2); if(jz(0x100e_c456, 0x26)) goto l_0x100e_c456; /* jz 0x100ec456 */
            ii(0x100e_c430, 6); test(memw[ss, ebp - 8], 1);             /* test word [ebp-0x8], 0x1 */
            ii(0x100e_c436, 2); if(jz(0x100e_c447, 0xf)) goto l_0x100e_c447; /* jz 0x100ec447 */
            ii(0x100e_c438, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x100e_c43d, 5); call(0x1007_6338, -0x7_610a);           /* call 0x10076338 */
            ii(0x100e_c442, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_c445, 2); jmp(0x100e_c47a, 0x33); goto l_0x100e_c47a; /* jmp 0x100ec47a */
        l_0x100e_c447:
            ii(0x100e_c447, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100e_c44c, 5); call(0x1007_6338, -0x7_6119);           /* call 0x10076338 */
            ii(0x100e_c451, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_c454, 2); jmp(0x100e_c47a, 0x24); goto l_0x100e_c47a; /* jmp 0x100ec47a */
        l_0x100e_c456:
            ii(0x100e_c456, 6); test(memw[ss, ebp - 8], 0x40);          /* test word [ebp-0x8], 0x40 */
            ii(0x100e_c45c, 2); if(jz(0x100e_c46d, 0xf)) goto l_0x100e_c46d; /* jz 0x100ec46d */
            ii(0x100e_c45e, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100e_c463, 5); call(0x1007_6338, -0x7_6130);           /* call 0x10076338 */
            ii(0x100e_c468, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_c46b, 2); jmp(0x100e_c47a, 0xd); goto l_0x100e_c47a; /* jmp 0x100ec47a */
        l_0x100e_c46d:
            ii(0x100e_c46d, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100e_c472, 5); call(0x1007_6338, -0x7_613f);           /* call 0x10076338 */
            ii(0x100e_c477, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
        l_0x100e_c47a:
            ii(0x100e_c47a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_c47d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_c47f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_c480, 1); pop(edi);                               /* pop edi */
            ii(0x100e_c481, 1); pop(esi);                               /* pop esi */
            ii(0x100e_c482, 1); pop(edx);                               /* pop edx */
            ii(0x100e_c483, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_c484, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_c485, 1); ret();                                  /* ret */
        }
    }
}

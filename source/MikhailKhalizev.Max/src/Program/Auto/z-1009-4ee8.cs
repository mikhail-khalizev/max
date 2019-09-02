using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_4ee8-a8c618a5")]
        public void Method_1009_4ee8()
        {
            ii(0x1009_4ee8, 5); push(0x20);                             /* push 0x20 */
            ii(0x1009_4eed, 5); call(Definitions.sys_check_available_stack_size, 0xd_0e60); /* call 0x10165d52 */
            ii(0x1009_4ef2, 1); push(ecx);                              /* push ecx */
            ii(0x1009_4ef3, 1); push(esi);                              /* push esi */
            ii(0x1009_4ef4, 1); push(edi);                              /* push edi */
            ii(0x1009_4ef5, 1); push(ebp);                              /* push ebp */
            ii(0x1009_4ef6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_4ef8, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_4efe, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1009_4f01, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1009_4f04, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1009_4f07, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_4f0a, 3); mov(edx, memd[ds, eax + 8]);            /* mov edx, [eax+0x8] */
            ii(0x1009_4f0d, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_4f10, 2); cmp(edx, memd[ds, eax]);                /* cmp edx, [eax] */
            ii(0x1009_4f12, 2); if(jle(0x1009_4f21, 0xd)) goto l_0x1009_4f21; /* jle 0x10094f21 */
            ii(0x1009_4f14, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_4f17, 3); mov(edx, memd[ds, eax + 8]);            /* mov edx, [eax+0x8] */
            ii(0x1009_4f1a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_4f1d, 2); cmp(edx, memd[ds, eax]);                /* cmp edx, [eax] */
            ii(0x1009_4f1f, 2); if(jg(0x1009_4f23, 2)) goto l_0x1009_4f23; /* jg 0x10094f23 */
        l_0x1009_4f21:
            ii(0x1009_4f21, 2); jmp(0x1009_4f77, 0x54); goto l_0x1009_4f77; /* jmp 0x10094f77 */
        l_0x1009_4f23:
            ii(0x1009_4f23, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_4f26, 3); mov(edx, memd[ds, eax + 12]);           /* mov edx, [eax+0xc] */
            ii(0x1009_4f29, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_4f2c, 3); cmp(edx, memd[ds, eax + 4]);            /* cmp edx, [eax+0x4] */
            ii(0x1009_4f2f, 2); if(jg(0x1009_4f3f, 0xe)) goto l_0x1009_4f3f; /* jg 0x10094f3f */
            ii(0x1009_4f31, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_4f34, 3); mov(edx, memd[ds, eax + 12]);           /* mov edx, [eax+0xc] */
            ii(0x1009_4f37, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4f3a, 3); cmp(edx, memd[ds, eax + 4]);            /* cmp edx, [eax+0x4] */
            ii(0x1009_4f3d, 2); if(jg(0x1009_4f41, 2)) goto l_0x1009_4f41; /* jg 0x10094f41 */
        l_0x1009_4f3f:
            ii(0x1009_4f3f, 2); jmp(0x1009_4f4d, 0xc); goto l_0x1009_4f4d; /* jmp 0x10094f4d */
        l_0x1009_4f41:
            ii(0x1009_4f41, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_4f44, 3); mov(edx, memd[ds, eax + 12]);           /* mov edx, [eax+0xc] */
            ii(0x1009_4f47, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4f4a, 3); mov(memd[ds, eax + 4], edx);            /* mov [eax+0x4], edx */
        l_0x1009_4f4d:
            ii(0x1009_4f4d, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_4f50, 3); mov(edx, memd[ds, eax + 12]);           /* mov edx, [eax+0xc] */
            ii(0x1009_4f53, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_4f56, 3); cmp(edx, memd[ds, eax + 4]);            /* cmp edx, [eax+0x4] */
            ii(0x1009_4f59, 2); if(jg(0x1009_4f69, 0xe)) goto l_0x1009_4f69; /* jg 0x10094f69 */
            ii(0x1009_4f5b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_4f5e, 3); mov(edx, memd[ds, eax + 4]);            /* mov edx, [eax+0x4] */
            ii(0x1009_4f61, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4f64, 3); cmp(edx, memd[ds, eax + 12]);           /* cmp edx, [eax+0xc] */
            ii(0x1009_4f67, 2); if(jl(0x1009_4f6b, 2)) goto l_0x1009_4f6b; /* jl 0x10094f6b */
        l_0x1009_4f69:
            ii(0x1009_4f69, 2); jmp(0x1009_4f77, 0xc); goto l_0x1009_4f77; /* jmp 0x10094f77 */
        l_0x1009_4f6b:
            ii(0x1009_4f6b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_4f6e, 3); mov(edx, memd[ds, eax + 4]);            /* mov edx, [eax+0x4] */
            ii(0x1009_4f71, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4f74, 3); mov(memd[ds, eax + 12], edx);           /* mov [eax+0xc], edx */
        l_0x1009_4f77:
            ii(0x1009_4f77, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_4f7a, 3); mov(edx, memd[ds, eax + 12]);           /* mov edx, [eax+0xc] */
            ii(0x1009_4f7d, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_4f80, 3); cmp(edx, memd[ds, eax + 4]);            /* cmp edx, [eax+0x4] */
            ii(0x1009_4f83, 2); if(jle(0x1009_4f93, 0xe)) goto l_0x1009_4f93; /* jle 0x10094f93 */
            ii(0x1009_4f85, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_4f88, 3); mov(edx, memd[ds, eax + 12]);           /* mov edx, [eax+0xc] */
            ii(0x1009_4f8b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_4f8e, 3); cmp(edx, memd[ds, eax + 4]);            /* cmp edx, [eax+0x4] */
            ii(0x1009_4f91, 2); if(jg(0x1009_4f95, 2)) goto l_0x1009_4f95; /* jg 0x10094f95 */
        l_0x1009_4f93:
            ii(0x1009_4f93, 2); jmp(0x1009_4fe3, 0x4e); goto l_0x1009_4fe3; /* jmp 0x10094fe3 */
        l_0x1009_4f95:
            ii(0x1009_4f95, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_4f98, 3); mov(edx, memd[ds, eax + 8]);            /* mov edx, [eax+0x8] */
            ii(0x1009_4f9b, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_4f9e, 2); cmp(edx, memd[ds, eax]);                /* cmp edx, [eax] */
            ii(0x1009_4fa0, 2); if(jg(0x1009_4faf, 0xd)) goto l_0x1009_4faf; /* jg 0x10094faf */
            ii(0x1009_4fa2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_4fa5, 3); mov(edx, memd[ds, eax + 8]);            /* mov edx, [eax+0x8] */
            ii(0x1009_4fa8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4fab, 2); cmp(edx, memd[ds, eax]);                /* cmp edx, [eax] */
            ii(0x1009_4fad, 2); if(jg(0x1009_4fb1, 2)) goto l_0x1009_4fb1; /* jg 0x10094fb1 */
        l_0x1009_4faf:
            ii(0x1009_4faf, 2); jmp(0x1009_4fbc, 0xb); goto l_0x1009_4fbc; /* jmp 0x10094fbc */
        l_0x1009_4fb1:
            ii(0x1009_4fb1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_4fb4, 3); mov(edx, memd[ds, eax + 8]);            /* mov edx, [eax+0x8] */
            ii(0x1009_4fb7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4fba, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
        l_0x1009_4fbc:
            ii(0x1009_4fbc, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_4fbf, 3); mov(edx, memd[ds, eax + 8]);            /* mov edx, [eax+0x8] */
            ii(0x1009_4fc2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_4fc5, 2); cmp(edx, memd[ds, eax]);                /* cmp edx, [eax] */
            ii(0x1009_4fc7, 2); if(jg(0x1009_4fd6, 0xd)) goto l_0x1009_4fd6; /* jg 0x10094fd6 */
            ii(0x1009_4fc9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_4fcc, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1009_4fce, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4fd1, 3); cmp(edx, memd[ds, eax + 8]);            /* cmp edx, [eax+0x8] */
            ii(0x1009_4fd4, 2); if(jl(0x1009_4fd8, 2)) goto l_0x1009_4fd8; /* jl 0x10094fd8 */
        l_0x1009_4fd6:
            ii(0x1009_4fd6, 2); jmp(0x1009_4fe3, 0xb); goto l_0x1009_4fe3; /* jmp 0x10094fe3 */
        l_0x1009_4fd8:
            ii(0x1009_4fd8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_4fdb, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1009_4fdd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4fe0, 3); mov(memd[ds, eax + 8], edx);            /* mov [eax+0x8], edx */
        l_0x1009_4fe3:
            ii(0x1009_4fe3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_4fe5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_4fe6, 1); pop(edi);                               /* pop edi */
            ii(0x1009_4fe7, 1); pop(esi);                               /* pop esi */
            ii(0x1009_4fe8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_4fe9, 1); ret();                                  /* ret */
        }
    }
}

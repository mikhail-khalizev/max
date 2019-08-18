using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2654fbaa-da6a-44df-9056-aaf4a8871457")]
        public void Method_1008_d34f()
        {
            ii(0x1008_d34f, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_d354, 5); calld(Definitions.sys_check_available_stack_size, 0xd_89f9); /* call 0x10165d52 */
            ii(0x1008_d359, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_d35a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_d35b, 1); pushd(esi);                             /* push esi */
            ii(0x1008_d35c, 1); pushd(edi);                             /* push edi */
            ii(0x1008_d35d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_d35e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_d360, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_d366, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_d369, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_d36c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_d36f, 3); mov(eax, memd_a32[ds, eax + 0x11]);     /* mov eax, [eax+0x11] */
            ii(0x1008_d372, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_d375, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1008_d378, 7); test(memb_a32[ds, eax + 0x101c_81c0], 0x10); /* test byte [eax+0x101c81c0], 0x10 */
            ii(0x1008_d37f, 2); if(jzd(0x1008_d38a, 0x9)) goto l_0x1008_d38a; /* jz 0x1008d38a */
            ii(0x1008_d381, 7); mov(memd_a32[ss, ebp - 0xc], 0x2);      /* mov dword [ebp-0xc], 0x2 */
            ii(0x1008_d388, 2); jmpd(0x1008_d391, 0x7); goto l_0x1008_d391; /* jmp 0x1008d391 */
        l_0x1008_d38a:
            ii(0x1008_d38a, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
        l_0x1008_d391:
            ii(0x1008_d391, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_d394, 3); mov(edx, memd_a32[ds, eax + 0x1f]);     /* mov edx, [eax+0x1f] */
            ii(0x1008_d397, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_d39a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d39d, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1008_d39f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_d3a2, 3); mov(edx, memd_a32[ds, eax + 0x21]);     /* mov edx, [eax+0x21] */
            ii(0x1008_d3a5, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_d3a8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d3ab, 3); mov(memd_a32[ds, eax + 0x4], edx);      /* mov [eax+0x4], edx */
            ii(0x1008_d3ae, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_d3b1, 3); mov(ebx, memd_a32[ds, eax + 0x1f]);     /* mov ebx, [eax+0x1f] */
            ii(0x1008_d3b4, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_d3b7, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1008_d3bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d3be, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1008_d3c0, 3); mov(memd_a32[ds, eax + 0x8], ebx);      /* mov [eax+0x8], ebx */
            ii(0x1008_d3c3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_d3c6, 3); mov(ebx, memd_a32[ds, eax + 0x21]);     /* mov ebx, [eax+0x21] */
            ii(0x1008_d3c9, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_d3cc, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1008_d3d0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d3d3, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1008_d3d5, 3); mov(memd_a32[ds, eax + 0xc], ebx);      /* mov [eax+0xc], ebx */
            ii(0x1008_d3d8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d3db, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_d3de, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_d3e1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_d3e3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_d3e4, 1); popd(edi);                              /* pop edi */
            ii(0x1008_d3e5, 1); popd(esi);                              /* pop esi */
            ii(0x1008_d3e6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_d3e7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_d3e8, 1); retd(); return;                         /* ret */
        }
    }
}

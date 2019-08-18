using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_01bb-74963b32")]
        public void Method_100f_01bb()
        {
            ii(0x100f_01bb, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100f_01c0, 5); calld(Definitions.sys_check_available_stack_size, 0x7_5b8d); /* call 0x10165d52 */
            ii(0x100f_01c5, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_01c6, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_01c7, 1); pushd(edx);                             /* push edx */
            ii(0x100f_01c8, 1); pushd(esi);                             /* push esi */
            ii(0x100f_01c9, 1); pushd(edi);                             /* push edi */
            ii(0x100f_01ca, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_01cb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_01cd, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100f_01d3, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_01d6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_01d9, 4); mov(dx, memw_a32[ds, eax + 0x67]);      /* mov dx, [eax+0x67] */
            ii(0x100f_01dd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_01e0, 4); mov(memw_a32[ds, eax + 0x4], dx);       /* mov [eax+0x4], dx */
            ii(0x100f_01e4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_01e7, 4); mov(ax, memw_a32[ds, eax + 0x61]);      /* mov ax, [eax+0x61] */
            ii(0x100f_01eb, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100f_01ee, 4); sub(ax, memw_a32[ds, edx + 0x67]);      /* sub ax, [edx+0x67] */
            ii(0x100f_01f2, 1); inc(eax);                               /* inc eax */
            ii(0x100f_01f3, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_01f6, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100f_01fa, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x100f_01fd, 2); if(jbed(0x100f_0206, 0x7)) goto l_0x100f_0206; /* jbe 0x100f0206 */
            ii(0x100f_01ff, 7); mov(memd_a32[ss, ebp - 0x10], 0x5);     /* mov dword [ebp-0x10], 0x5 */
        l_0x100f_0206:
            ii(0x100f_0206, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100f_020d, 2); jmpd(0x100f_0215, 0x6); goto l_0x100f_0215; /* jmp 0x100f0215 */
        l_0x100f_020f:
            ii(0x100f_020f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_0212, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100f_0215:
            ii(0x100f_0215, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_0218, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x100f_021c, 2); if(jged(0x100f_0243, 0x25)) goto l_0x100f_0243; /* jge 0x100f0243 */
            ii(0x100f_021e, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_0222, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x100f_0225, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100f_0228, 3); add(edx, 0x8);                          /* add edx, 0x8 */
            ii(0x100f_022b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_022d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_0230, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100f_0232, 5); calld(0x100f_008a, -0x1ad);             /* call 0x100f008a */
            ii(0x100f_0237, 2); test(al, al);                           /* test al, al */
            ii(0x100f_0239, 2); if(jnzd(0x100f_0241, 0x6)) goto l_0x100f_0241; /* jnz 0x100f0241 */
            ii(0x100f_023b, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100f_023f, 2); jmpd(0x100f_0247, 0x6); goto l_0x100f_0247; /* jmp 0x100f0247 */
        l_0x100f_0241:
            ii(0x100f_0241, 2); jmpd(0x100f_020f, -0x34); goto l_0x100f_020f; /* jmp 0x100f020f */
        l_0x100f_0243:
            ii(0x100f_0243, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
        l_0x100f_0247:
            ii(0x100f_0247, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100f_024a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_024c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_024d, 1); popd(edi);                              /* pop edi */
            ii(0x100f_024e, 1); popd(esi);                              /* pop esi */
            ii(0x100f_024f, 1); popd(edx);                              /* pop edx */
            ii(0x100f_0250, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_0251, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_0252, 1); retd(); return;                         /* ret */
        }
    }
}

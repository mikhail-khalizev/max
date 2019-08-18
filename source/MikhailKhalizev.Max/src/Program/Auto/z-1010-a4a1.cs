using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0755f3fa-90cf-4d98-9473-9863d3f9c7e6")]
        public void Method_1010_a4a1()
        {
            ii(0x1010_a4a1, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1010_a4a6, 5); calld(Definitions.sys_check_available_stack_size, 0x5_b8a7); /* call 0x10165d52 */
            ii(0x1010_a4ab, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_a4ac, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_a4ad, 1); pushd(edx);                             /* push edx */
            ii(0x1010_a4ae, 1); pushd(esi);                             /* push esi */
            ii(0x1010_a4af, 1); pushd(edi);                             /* push edi */
            ii(0x1010_a4b0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_a4b1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_a4b3, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1010_a4b9, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_a4bc, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1010_a4c1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_a4c4, 5); calld(0x1010_a26b, -0x25e);             /* call 0x1010a26b */
            ii(0x1010_a4c9, 7); mov(memd_a32[ss, ebp - 0xc], 0x6);      /* mov dword [ebp-0xc], 0x6 */
        l_0x1010_a4d0:
            ii(0x1010_a4d0, 3); dec(memd_a32[ss, ebp - 0xc]);           /* dec dword [ebp-0xc] */
            ii(0x1010_a4d3, 5); cmp(memw_a32[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x1010_a4d8, 2); if(jzd(0x1010_a50a, 0x30)) goto l_0x1010_a50a; /* jz 0x1010a50a */
            ii(0x1010_a4da, 5); calld(0x1011_52a8, 0xadc9);             /* call 0x101152a8 */
            ii(0x1010_a4df, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_a4e1, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1010_a4e3, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1010_a4e6, 5); calld(0x1011_52c8, 0xaddd);             /* call 0x101152c8 */
            ii(0x1010_a4eb, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_a4ed, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_a4f1, 3); add(eax, 0x1f);                         /* add eax, 0x1f */
            ii(0x1010_a4f4, 3); imul(eax, eax, 0x14);                   /* imul eax, eax, 0x14 */
            ii(0x1010_a4f7, 5); mov(edx, 0x101b_a5ac);                  /* mov edx, 0x101ba5ac */
            ii(0x1010_a4fc, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_a4fe, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_a501, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_a503, 5); calld(0x1010_a2d7, -0x231);             /* call 0x1010a2d7 */
            ii(0x1010_a508, 2); jmpd(0x1010_a4d0, -0x3a); goto l_0x1010_a4d0; /* jmp 0x1010a4d0 */
        l_0x1010_a50a:
            ii(0x1010_a50a, 5); mov(eax, 0x48);                         /* mov eax, 0x48 */
            ii(0x1010_a50f, 5); calld(0x1007_5fdc, -0x9_4538);          /* call 0x10075fdc */
            ii(0x1010_a514, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_a517, 7); mov(memd_a32[ss, ebp - 0xc], 0x6);      /* mov dword [ebp-0xc], 0x6 */
        l_0x1010_a51e:
            ii(0x1010_a51e, 3); dec(memd_a32[ss, ebp - 0xc]);           /* dec dword [ebp-0xc] */
            ii(0x1010_a521, 5); cmp(memw_a32[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x1010_a526, 2); if(jzd(0x1010_a545, 0x1d)) goto l_0x1010_a545; /* jz 0x1010a545 */
            ii(0x1010_a528, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_a52c, 3); add(eax, 0x25);                         /* add eax, 0x25 */
            ii(0x1010_a52f, 3); imul(eax, eax, 0x14);                   /* imul eax, eax, 0x14 */
            ii(0x1010_a532, 6); mov(eax, memd_a32[ds, eax + 0x101b_a5bc]); /* mov eax, [eax+0x101ba5bc] */
            ii(0x1010_a538, 5); calld(/* sys */ 0x1017_90ce, 0x6_eb91); /* call 0x101790ce */
            ii(0x1010_a53d, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_a541, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_a543, 2); if(jld(0x1010_a51e, -0x27)) goto l_0x1010_a51e; /* jl 0x1010a51e */
        l_0x1010_a545:
            ii(0x1010_a545, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x1010_a549, 5); mov(ebx, 0x25);                         /* mov ebx, 0x25 */
            ii(0x1010_a54e, 5); mov(edx, 0x6);                          /* mov edx, 0x6 */
            ii(0x1010_a553, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_a556, 5); calld(0x1010_a36e, -0x1ed);             /* call 0x1010a36e */
            ii(0x1010_a55b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_a55d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_a55e, 1); popd(edi);                              /* pop edi */
            ii(0x1010_a55f, 1); popd(esi);                              /* pop esi */
            ii(0x1010_a560, 1); popd(edx);                              /* pop edx */
            ii(0x1010_a561, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_a562, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_a563, 1); retd(); return;                         /* ret */
        }
    }
}

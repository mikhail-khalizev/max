using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5fac9c36-9212-4187-94a5-014c886f37fb")]
        public void Method_1010_3ff1()
        {
            ii(0x1010_3ff1, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1010_3ff6, 5); calld(Definitions.sys_check_available_stack_size, 0x61d57); /* call 0x10165d52 */
            ii(0x1010_3ffb, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_3ffc, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_3ffd, 1); pushd(edx);                             /* push edx */
            ii(0x1010_3ffe, 1); pushd(esi);                             /* push esi */
            ii(0x1010_3fff, 1); pushd(edi);                             /* push edi */
            ii(0x1010_4000, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_4001, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_4003, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1010_4009, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_400c, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1010_4010, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1010_4013, 5); calld(0x1007_64fc, -0x8db1c);           /* call 0x100764fc */
            ii(0x1010_4018, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_401b, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1010_401f, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1010_4026, 2); jmpd(0x1010_402e, 0x6); goto l_0x1010_402e; /* jmp 0x1010402e */
        l_0x1010_4028:
            ii(0x1010_4028, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_402b, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1010_402e:
            ii(0x1010_402e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_4031, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_4034, 3); cmp(ax, memw_a32[ds, edx]);             /* cmp ax, [edx] */
            ii(0x1010_4037, 2); if(jged(0x1010_40a3, 0x6a)) goto l_0x1010_40a3; /* jge 0x101040a3 */
            ii(0x1010_4039, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1010_403d, 3); imul(edx, edx, 0xa);                    /* imul edx, edx, 0xa */
            ii(0x1010_4040, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_4043, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x1010_4046, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_4048, 5); calld(0x1007_6338, -0x8dd15);           /* call 0x10076338 */
            ii(0x1010_404d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_404f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1010_4052, 5); calld(0x1007_643c, -0x8dc1b);           /* call 0x1007643c */
            ii(0x1010_4057, 2); jmpd(0x1010_4061, 0x8); goto l_0x1010_4061; /* jmp 0x10104061 */
        l_0x1010_4059:
            ii(0x1010_4059, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1010_405c, 5); calld(0x1007_6bf8, -0x8d469);           /* call 0x10076bf8 */
        l_0x1010_4061:
            ii(0x1010_4061, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_4063, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1010_4066, 5); calld(0x1013_ad71, 0x36d06);            /* call 0x1013ad71 */
            ii(0x1010_406b, 2); test(al, al);                           /* test al, al */
            ii(0x1010_406d, 2); if(jzd(0x1010_408d, 0x1e)) goto l_0x1010_408d; /* jz 0x1010408d */
            ii(0x1010_406f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1010_4072, 5); calld(0x1007_63a0, -0x8dcd7);           /* call 0x100763a0 */
            ii(0x1010_4077, 5); calld(0x1014_b6bd, 0x47641);            /* call 0x1014b6bd */
            ii(0x1010_407c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_407e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1010_4081, 5); calld(0x1007_63a0, -0x8dce6);           /* call 0x100763a0 */
            ii(0x1010_4086, 5); calld(0x1008_a998, -0x796f3);           /* call 0x1008a998 */
            ii(0x1010_408b, 2); jmpd(0x1010_4059, -0x34); goto l_0x1010_4059; /* jmp 0x10104059 */
        l_0x1010_408d:
            ii(0x1010_408d, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_4091, 3); imul(edx, eax, 0xa);                    /* imul edx, eax, 0xa */
            ii(0x1010_4094, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_4097, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x1010_409a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_409c, 5); calld(0x1013_a6f4, 0x36653);            /* call 0x1013a6f4 */
            ii(0x1010_40a1, 2); jmpd(0x1010_4028, -0x7b); goto l_0x1010_4028; /* jmp 0x10104028 */
        l_0x1010_40a3:
            ii(0x1010_40a3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_40a5, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1010_40a8, 5); calld(0x1007_5f6c, -0x8e141);           /* call 0x10075f6c */
            ii(0x1010_40ad, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_40af, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_40b0, 1); popd(edi);                              /* pop edi */
            ii(0x1010_40b1, 1); popd(esi);                              /* pop esi */
            ii(0x1010_40b2, 1); popd(edx);                              /* pop edx */
            ii(0x1010_40b3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_40b4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_40b5, 1); retd(); return;                         /* ret */
        }
    }
}